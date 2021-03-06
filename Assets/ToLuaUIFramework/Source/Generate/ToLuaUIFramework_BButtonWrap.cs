﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ToLuaUIFramework_BButtonWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ToLuaUIFramework.BButton), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("OnPointerDown", OnPointerDown);
		L.RegFunction("OnPointerClick", OnPointerClick);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("param", get_param, set_param);
		L.RegVar("canTriggerInterval", get_canTriggerInterval, set_canTriggerInterval);
		L.RegVar("onClick", get_onClick, set_onClick);
		L.RegVar("onPointerDown", get_onPointerDown, set_onPointerDown);
		L.RegVar("rectTransform", get_rectTransform, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)ToLua.CheckObject<ToLuaUIFramework.BButton>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerDown(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)ToLua.CheckObject<ToLuaUIFramework.BButton>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerClick(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_param(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)o;
			object ret = obj.param;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index param on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canTriggerInterval(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)o;
			float ret = obj.canTriggerInterval;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index canTriggerInterval on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)o;
			System.Action<object> ret = obj.onClick;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPointerDown(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)o;
			System.Action<object> ret = obj.onPointerDown;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onPointerDown on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rectTransform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)o;
			UnityEngine.RectTransform ret = obj.rectTransform;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rectTransform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_param(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)o;
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.param = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index param on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_canTriggerInterval(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.canTriggerInterval = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index canTriggerInterval on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)o;
			System.Action<object> arg0 = (System.Action<object>)ToLua.CheckDelegate<System.Action<object>>(L, 2);
			obj.onClick = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPointerDown(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ToLuaUIFramework.BButton obj = (ToLuaUIFramework.BButton)o;
			System.Action<object> arg0 = (System.Action<object>)ToLua.CheckDelegate<System.Action<object>>(L, 2);
			obj.onPointerDown = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onPointerDown on a nil value");
		}
	}
}

