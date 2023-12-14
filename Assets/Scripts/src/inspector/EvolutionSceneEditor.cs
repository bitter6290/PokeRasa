#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(EvolutionScene))]
public class EvolutionSceneEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EvolutionScene scene = (EvolutionScene)target;
        DrawDefaultInspector();
        if (GUILayout.Button("Test"))
        {
            Pokemon mon = Pokemon.WildPokemon(SpeciesID.Magikarp, 21);
            mon.evolveAfterBattle = true;
            mon.destinationSpecies = SpeciesID.Gyarados;

            scene.StartCoroutine(scene.PrepareScene(mon).Join(scene.DoEvolutionScene()));
        }
    }
}
#endif