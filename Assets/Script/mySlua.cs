﻿using UnityEngine;
using SLua;

public class mySlua : MonoBehaviour{

    private static LuaState ls_state;

    void Start()
    {
        ls_state = new LuaState();
        ls_state.doString("print(\"Hello Lua!\")");

    }

}

