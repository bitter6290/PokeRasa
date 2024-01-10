using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ScriptUtils;

namespace Scripts.General
{
    public static class NurseUtils
    {
        public static readonly Sprite pokeball = Sprite.Create(
            Resources.Load<Texture2D>("Sprites/Field/pokeball"),
            new(0, 0, 8, 8), StaticValues.defPivot, 16);
        public static readonly Sprite screen = Sprite.Create(
            Resources.Load<Texture2D>("Sprites/Field/center_screen"),
            new(0, 0, 24, 16), StaticValues.defPivot, 16);
        public static readonly AudioClip heal = Resources.Load<AudioClip>("Sound/Field SFX/CenterHeal");
    }
    public class PokeCenterNurse : TriggerScript
    {
        private static readonly Vector2[] ballPositions = new Vector2[6]
        {
            new(-1.75f,0.75f),
            new(-1.25f,0.75f),
            new(-1.75f,0.5f),
            new(-1.25f,0.5f),
            new(-1.75f,0.25f),
            new(-1.25f,0.25f)
        };
        public override IEnumerator OnTrigger(Player p)
        {
            (_, LoadedChar nurse) = p.loadedChars["nurse"];
            p.locked = true;
            p.state = PlayerState.Announce;
            nurse.FaceAndLock();
            yield return p.announcer.AnnouncementUp();
            yield return p.announcer.Announce("Hello, and welcome to the Pokémon Center.");
            yield return p.announcer.Announce("We restore your tired Pokémon to full health.", true);
            yield return p.announcer.Announce("Would you like to rest your Pokémon?", true, true);
            DataStore<int> menuResult = new();
            yield return ChoiceMenu.DoChoiceMenu(p, BinaryChoice, 0, menuResult, p.announcer.transform, new(-400, 60), Vector2.zero);
            if (menuResult.Data is 1)
            {
                yield return p.announcer.Announce("OK, I'll take your Pokémon for a few seconds.");
                HealAll(p);
                List<GameObject> ballObjects = new();
                List<SpriteRenderer> ballSprites = new();
                int i = 0;
                foreach (Pokemon mon in p.Party)
                {
                    if (!mon.exists) break;
                    if (mon.egg) continue;
                    GameObject newBall = new();
                    ballObjects.Add(newBall);
                    newBall.transform.parent = nurse.transform;
                    newBall.transform.localPosition = ballPositions[i];
                    SpriteRenderer renderer = newBall.AddComponent<SpriteRenderer>();
                    ballSprites.Add(renderer);
                    renderer.sprite = NurseUtils.pokeball;
                    p.audioSource.PlayOneShot(SFX.BallShake);
                    yield return new WaitForSeconds(0.5f);
                    i++;
                }
                GameObject screen = new();
                screen.transform.parent = nurse.transform;
                screen.transform.localPosition = new(0.25f, 1.5f);
                SpriteRenderer screenRenderer = screen.AddComponent<SpriteRenderer>();
                screenRenderer.sprite = NurseUtils.screen;
                screenRenderer.color = new(1, 1, 1, 0);
                p.audioSource.PlayOneShot(NurseUtils.heal);
                for (int j = 0; j < 4; j++)
                {
                    foreach (SpriteRenderer ball in ballSprites)
                    {
                        p.StartCoroutine(AnimUtils.ColorChange(ball, Color.white, Color.yellow, 0.2f));
                    }
                    yield return AnimUtils.Fade(screenRenderer, 1, 0.22f);
                    foreach (SpriteRenderer ball in ballSprites)
                    {
                        p.StartCoroutine(AnimUtils.ColorChange(ball, Color.yellow, Color.white, 0.2f));
                    }
                    yield return AnimUtils.Fade(screenRenderer, 0, 0.22f);
                }
                yield return new WaitForSeconds(1.0f);
                foreach (GameObject obj in ballObjects)
                {
                    Destroy(obj);
                }
                Destroy(screen);
                yield return p.announcer.Announce("Thank you for waiting.");
                yield return p.announcer.Announce("We've restored your Pokémon to full health.", true);
            }
            yield return p.announcer.Announce("We hope to see you again!", menuResult.Data is 1);
            yield return p.announcer.AnnouncementDown();
            p.locked = false;
            p.state = PlayerState.Free;
            nurse.free = true;
        }
    }
}