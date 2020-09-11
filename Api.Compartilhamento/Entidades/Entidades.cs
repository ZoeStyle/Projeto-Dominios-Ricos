using System;
using Flunt.Notifications;

namespace Api.Compartilhamento.Entidades
{
    // => Esta classe é para gerar o Id das minhas entidades
    // => A classe Notifiable vem do projeto flunt que serve para validação de campos
    public abstract class Entidades : Notifiable
    {
        protected Entidades()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}