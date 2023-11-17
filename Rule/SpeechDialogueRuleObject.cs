using ContextualDialogueSystem.Rule.Content;
using UnityEngine;

namespace ContextualDialogueSystem.Rule
{
    [CreateAssetMenu(fileName = OBJECT_NAME, menuName = OBJECT_PATH + OBJECT_NAME)]
    public class SpeechDialogueRuleObject : DialogueRuleObject<ISpeechContent<string>>
    {
        private new const string OBJECT_NAME = "Speech Dialogue Rule";

        [SerializeField]
        private SpeechContent _content;
        public override ISpeechContent<string> Content => _content;
    }
}
