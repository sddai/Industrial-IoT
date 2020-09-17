namespace Microsoft.Azure.IIoT.Core.Autofac {
    using System;
    using af = global::Autofac;
    using afc = global::Autofac.Core;
    

    /// <summary>
    /// Module that logs Autofac resolving into console
    /// </summary>
    public class LogResolvingModule : af.Module {

        /// <inheritdoc/>
        protected override void AttachToComponentRegistration(
            afc.Registration.IComponentRegistryBuilder componentRegistry, 
            afc.IComponentRegistration registration) {

            registration.Preparing += (sender, args) => {
                Console.Out.WriteLineAsync($"{GetPrefix()} Resolving {args.Component.Activator.LimitType}");
                _level++;
            };

            registration.Activating += (sender, args) => {
                _level--;
                Console.Out.WriteLineAsync($"{GetPrefix()} Activating {args.Component.Activator.LimitType}");
            };
            
            base.AttachToComponentRegistration(componentRegistry, registration);
        }

        private string GetPrefix() {
            return new string('-', _level * 2);
        }

        private int _level = 0;
    }
}
