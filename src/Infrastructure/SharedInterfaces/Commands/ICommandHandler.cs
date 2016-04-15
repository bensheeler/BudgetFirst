﻿namespace BudgetFirst.SharedInterfaces.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICommandHandler<TCommand> where TCommand : ICommand 
    {
        void Handle(TCommand command);
    }
}
