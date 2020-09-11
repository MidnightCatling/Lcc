﻿using UnityEngine;
using UnityEngine.UI;

namespace Hotfix
{
    public class LogInfo : Info
    {
        public LogType type;
        public string log;
        public Text logText;
        public void SetLog(string log)
        {
            this.log = log;
            logText.text = log;
        }
        public override void OpenPanel()
        {
            if (ContainerExist())
            {
                state = InfoState.Open;
                container.SetActive(true);
            }
            else
            {
                Debug.Log(type.ToString() + ":null");
            }
        }
        public override void ClosePanel()
        {
            if (ContainerExist())
            {
                state = InfoState.Close;
                container.SetActive(false);
            }
            else
            {
                Debug.Log(type.ToString() + ":null");
            }
        }
    }
}