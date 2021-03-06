﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class MongoDBBsonBsonExceptionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.BsonException);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MongoDB.Bson.BsonException gen_ret = new MongoDB.Bson.BsonException();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string _message = LuaAPI.lua_tostring(L, 2);
					
					MongoDB.Bson.BsonException gen_ret = new MongoDB.Bson.BsonException(_message);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<System.Exception>(L, 3))
				{
					string _message = LuaAPI.lua_tostring(L, 2);
					System.Exception _innerException = (System.Exception)translator.GetObject(L, 3, typeof(System.Exception));
					
					MongoDB.Bson.BsonException gen_ret = new MongoDB.Bson.BsonException(_message, _innerException);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<object>(L, 3)))
				{
					string _format = LuaAPI.lua_tostring(L, 2);
					object[] _args = translator.GetParams<object>(L, 3);
					
					MongoDB.Bson.BsonException gen_ret = new MongoDB.Bson.BsonException(_format, _args);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Runtime.Serialization.SerializationInfo>(L, 2) && translator.Assignable<System.Runtime.Serialization.StreamingContext>(L, 3))
				{
					System.Runtime.Serialization.SerializationInfo _info = (System.Runtime.Serialization.SerializationInfo)translator.GetObject(L, 2, typeof(System.Runtime.Serialization.SerializationInfo));
					System.Runtime.Serialization.StreamingContext _context;translator.Get(L, 3, out _context);
					
					MongoDB.Bson.BsonException gen_ret = new MongoDB.Bson.BsonException(_info, _context);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonException constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
