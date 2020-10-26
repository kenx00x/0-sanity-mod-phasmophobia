using MelonLoader;
namespace _0_sanity
{
    public class Class1 : MelonMod
    {
        public override void OnUpdate()
        {
            base.OnUpdate();
            GameController.instance.myPlayer.player.insanity = 100;

        }
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            MelonLogger.Log("0 sanity mod loaded!");
        }
    }
}
