using System;
using System.Data;
using System.Collections.Generic;

namespace OA_CRM.Models{
    public class AddMsg
    {
        public MESSAGE_HISTORY msg { get; private set; }
        public List<MSG_RECEIVE_LIST> receiveLst { get; private set; }
        public AddMsg(MESSAGE_HISTORY msg, List<MSG_RECEIVE_LIST> reveiveLst)
        {
            this.msg = msg;
            this.receiveLst = receiveLst;
        }
    }
}