using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class FornecedorValidator : AbstractValidator<Fornecedor>
    {
        public FornecedorValidator()
        {
            RuleFor(fornecedor => fornecedor.Nome).NotEmpty().WithMessage("Campo NOME é obrigatório!");
            RuleFor(fornecedor => fornecedor.Nome).Length(10, 50).WithMessage("Tamanho do campo nome deve estar entre 10 e 45!");
            RuleFor(fornecedor => fornecedor.Email).NotEmpty().WithMessage("Campo EMAIL é obrigatório!")
                     .EmailAddress().WithMessage("Um email válido é requerido!");
            RuleFor(fornecedor => fornecedor.tipoPessoa).IsInEnum().WithMessage("Campo TipoPessoa deve ser especificado!");

            RuleFor(fornecedor => fornecedor.Numero).NotNull().WithMessage("Campo Número não pode ser vazio").NotEqual(0).WithMessage("Campo Número deve ser valido");

            RuleFor(fornecedor => fornecedor.Celular)
            .NotEmpty().WithMessage("Campo CELULAR é obrigatório!")
            .Matches(@"^\d{11}$").WithMessage("Celular deve conter exatamente 11 dígitos numéricos!");


            RuleFor(fornecedor => fornecedor.Cep)
            .NotEmpty().WithMessage("Campo CEP é obrigatório!")
            .Matches(@"^\d{8}$").WithMessage("CEP deve conter exatamente 8 dígitos numéricos!");


            RuleFor(fornecedor => fornecedor.Telefone)
            .NotEmpty().WithMessage("Campo TELEFONE é obrigatório!")
            .Matches(@"^\d{10,11}$").WithMessage("Telefone deve conter entre 10 e 11 dígitos numéricos!");

            RuleFor(fornecedor => fornecedor.Cpf_Cnpj)
                .NotEmpty().WithMessage("Campo CPF/CNPJ é obrigatório!");


            RuleFor(fornecedor => fornecedor.Numero)
           .NotEmpty().WithMessage("Campo NÚMERO é obrigatório!")
           .GreaterThan(0).WithMessage("O número deve ser maior que zero!");

            RuleFor(fornecedor => fornecedor.Rua).NotEmpty().WithMessage("Campo RUA é obrigatório!")
            .Length(5, 45).WithMessage("Tamanho do campo rua deve estar entre 5 e 45!");
            RuleFor(fornecedor => fornecedor.Bairro)
            .NotEmpty().WithMessage("Campo BAIRRO é obrigatório!")
            .Length(3, 45).WithMessage("Tamanho do campo bairro deve estar entre 3 e 45!");
            RuleFor(fornecedor => fornecedor.Razao_Social)
            .NotEmpty().WithMessage("Campo RAZÃO SOCIAL é obrigatório!")
            .Length(3, 45).WithMessage("Tamanho do campo razão social deve estar entre 3 e 45!");


        }



    }
}
