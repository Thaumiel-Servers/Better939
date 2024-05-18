namespace BetterDoggie
{
    using System;
    using System.Collections.Generic;
    using Exiled.API.Features;
    using Exiled.API.Enums;
    using MEC;
    
    using PlayerEvents = Exiled.Events.Handlers.Player; 
    
    public class Better939 : Plugin<Config>
    {
        public static Better939 Singleton;
        
        public override string Author => "MrBaguetter";
        public override string Name => "Better939";
        public override string Prefix => "Better_939";
        public override Version Version => new Version(0, 5, 0);
        public override Version RequiredExiledVersion => new Version(8, 8, 1);
        public override PluginPriority Priority => PluginPriority.Low;

        public Dictionary<Player, CoroutineHandle?> ActiveAbilities = new Dictionary<Player, CoroutineHandle?>();
        public Dictionary<Player, int> AbilityCooldowns = new Dictionary<Player, int>();
        
        public override void OnEnabled()
        {
            Singleton = this;
            
            PlayerEvents.ChangingRole += EventHandlers.OnChangingRoles;
            PlayerEvents.Hurting += EventHandlers.OnHurtingPlayer;
            PlayerEvents.InteractingDoor += EventHandlers.OnInteractingDoor;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerEvents.ChangingRole -= EventHandlers.OnChangingRoles;
            PlayerEvents.Hurting -= EventHandlers.OnHurtingPlayer;
            PlayerEvents.InteractingDoor -= EventHandlers.OnInteractingDoor;

            Singleton = null;
            
            base.OnDisabled();
        }
    }
}