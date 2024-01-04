using System.Collections;
using UnityEngine;
using static ScriptUtils;

namespace Scripts.General
{
    public class PokeCenterNurse : TriggerScript
    {
        public override IEnumerator OnTrigger(Player p)
        {
            (_, LoadedChar nurse) = p.loadedChars["nurse"];
            p.locked = true;
            p.state = PlayerState.Announce;
            nurse.FaceAndLock();
            yield return p.announcer.AnnouncementUp();
            yield return p.announcer.Announce("Hello, and welcome to the Pokémon Center.");
            yield return p.announcer.Announce("We restore your tired Pokémon to full health.");
            yield return p.announcer.Announce("Would you like to rest your Pokémon?", true);
            DataStore<int> menuResult = new();
            yield return ChoiceMenu.DoChoiceMenu(p, BinaryChoice, 0, menuResult, p.announcer.transform, new(-400, 60), Vector2.zero);
            if (menuResult.Data is 1)
            {
                yield return p.announcer.Announce("OK, I'll take your Pokémon for a few seconds.");
                HealAll(p);
                yield return new WaitForSeconds(2.0f); //Todo: Pokémon Center animation
                yield return p.announcer.Announce("Thank you for waiting.");
                yield return p.announcer.Announce("We've restored your Pokémon to full health.");
            }
            yield return p.announcer.Announce("We hope to see you again!");
            yield return p.announcer.AnnouncementDown();
            p.locked = false;
            p.state = PlayerState.Free;
            nurse.free = true;
        }
    }
}