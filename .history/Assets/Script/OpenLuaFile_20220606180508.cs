﻿using UnityEngine;
using System.Collections;
using SLua;
using System.IO;

public class OpenLuaFile : MonoBehaviour{

    public LuaState state;// sLua脚本代理

    void Start()
    {

        state = new LuaState();

        state.loaderDelegate = (()) =>{
            string file_Path = Directory.GetCurrentDirectory() + "/Assets/Script/Lua/" + fn;
            Debug.Log(file_Path);
            return File.ReadAllBytes(file_Path);
        });

        //执行脚本
        state.doFile("HelloLua.lua");
    }
}

