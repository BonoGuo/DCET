-- Generated by CSharp.lua Compiler
local System = System
local DCETHotfix
System.import(function (out)
  DCETHotfix = DCET.Hotfix
end)
System.namespace("DCET.Hotfix", function (namespace)
  namespace.interface("IDisposable", function ()
    return {}
  end)

  namespace.interface("ISupportInitialize", function ()
    return {}
  end)

  namespace.class("Object", function (namespace)
    local BeginInit, EndInit, ToString
    BeginInit = function (this)
    end
    EndInit = function (this)
    end
    ToString = function (this)
      return DCETHotfix.JsonHelper.ToJson(this)
    end
    return {
      __inherits__ = function (out)
        return {
          out.DCET.Hotfix.ISupportInitialize
        }
      end,
      BeginInit = BeginInit,
      EndInit = EndInit,
      ToString = ToString
    }
  end)
end)