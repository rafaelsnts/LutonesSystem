﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LutonesSystem.XPO.LutonesSystem
{

    [Persistent(@"tb_funcionarios")]
    public partial class tb_funcionariosXPO : XPLiteObject
    {
        int ffun_id;
        [Key(true)]
        public int fun_id
        {
            get { return ffun_id; }
            set { SetPropertyValue<int>(nameof(fun_id), ref ffun_id, value); }
        }
        string ffun_nome;
        [Size(50)]
        public string fun_nome
        {
            get { return ffun_nome; }
            set { SetPropertyValue<string>(nameof(fun_nome), ref ffun_nome, value); }
        }
        string ffun_cargo;
        [Size(50)]
        public string fun_cargo
        {
            get { return ffun_cargo; }
            set { SetPropertyValue<string>(nameof(fun_cargo), ref ffun_cargo, value); }
        }
        DateTime ffun_data_cadastro;
        public DateTime fun_data_cadastro
        {
            get { return ffun_data_cadastro; }
            set { SetPropertyValue<DateTime>(nameof(fun_data_cadastro), ref ffun_data_cadastro, value); }
        }
    }

}
