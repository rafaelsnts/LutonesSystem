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

    [Persistent(@"tb_fornecedores")]
    public partial class tb_fornecedoresXPO : XPLiteObject
    {
        int ffor_id;
        [Key(true)]
        public int for_id
        {
            get { return ffor_id; }
            set { SetPropertyValue<int>(nameof(for_id), ref ffor_id, value); }
        }
        string ffor_nome;
        [Size(50)]
        public string for_nome
        {
            get { return ffor_nome; }
            set { SetPropertyValue<string>(nameof(for_nome), ref ffor_nome, value); }
        }
        string ffor_cnpj;
        [Size(20)]
        public string for_cnpj
        {
            get { return ffor_cnpj; }
            set { SetPropertyValue<string>(nameof(for_cnpj), ref ffor_cnpj, value); }
        }
        string ffor_telefone;
        [Size(14)]
        public string for_telefone
        {
            get { return ffor_telefone; }
            set { SetPropertyValue<string>(nameof(for_telefone), ref ffor_telefone, value); }
        }
        string ffor_email;
        [Size(50)]
        public string for_email
        {
            get { return ffor_email; }
            set { SetPropertyValue<string>(nameof(for_email), ref ffor_email, value); }
        }
        DateTime ffor_data_cadastro;
        public DateTime for_data_cadastro
        {
            get { return ffor_data_cadastro; }
            set { SetPropertyValue<DateTime>(nameof(for_data_cadastro), ref ffor_data_cadastro, value); }
        }
        [Association(@"tb_insumosXPOReferencestb_fornecedoresXPO")]
        public XPCollection<tb_insumosXPO> tb_insumoss { get { return GetCollection<tb_insumosXPO>(nameof(tb_insumoss)); } }
    }

}
