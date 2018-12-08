﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NTGBattleUIController_BattleUpdatePlayerDataWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NTGBattleUIController.BattleUpdatePlayerData), typeof(System.Object));
		L.RegFunction("New", _CreateNTGBattleUIController_BattleUpdatePlayerData);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Valid", get_Valid, set_Valid);
		L.RegVar("HPRatio", get_HPRatio, set_HPRatio);
		L.RegVar("SkillReady", get_SkillReady, set_SkillReady);
		L.RegVar("ReviveCount", get_ReviveCount, set_ReviveCount);
		L.RegVar("Icon", get_Icon, set_Icon);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNTGBattleUIController_BattleUpdatePlayerData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				NTGBattleUIController.BattleUpdatePlayerData obj = new NTGBattleUIController.BattleUpdatePlayerData();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: NTGBattleUIController.BattleUpdatePlayerData.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Valid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdatePlayerData obj = (NTGBattleUIController.BattleUpdatePlayerData)o;
			bool ret = obj.Valid;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Valid on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_HPRatio(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdatePlayerData obj = (NTGBattleUIController.BattleUpdatePlayerData)o;
			float ret = obj.HPRatio;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index HPRatio on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SkillReady(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdatePlayerData obj = (NTGBattleUIController.BattleUpdatePlayerData)o;
			bool ret = obj.SkillReady;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index SkillReady on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ReviveCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdatePlayerData obj = (NTGBattleUIController.BattleUpdatePlayerData)o;
			int ret = obj.ReviveCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ReviveCount on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Icon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdatePlayerData obj = (NTGBattleUIController.BattleUpdatePlayerData)o;
			string ret = obj.Icon;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Icon on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Valid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdatePlayerData obj = (NTGBattleUIController.BattleUpdatePlayerData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Valid = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Valid on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_HPRatio(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdatePlayerData obj = (NTGBattleUIController.BattleUpdatePlayerData)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.HPRatio = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index HPRatio on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SkillReady(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdatePlayerData obj = (NTGBattleUIController.BattleUpdatePlayerData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.SkillReady = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index SkillReady on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ReviveCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdatePlayerData obj = (NTGBattleUIController.BattleUpdatePlayerData)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.ReviveCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ReviveCount on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Icon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleUIController.BattleUpdatePlayerData obj = (NTGBattleUIController.BattleUpdatePlayerData)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.Icon = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Icon on a nil value" : e.Message);
		}
	}
}
