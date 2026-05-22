using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public static class RemoteSettings : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002898 File Offset: 0x00000A98
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteSettings()
		{
			Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine", "RemoteSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr);
			RemoteSettings.NativeFieldInfoPtr_Updated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, "Updated");
			RemoteSettings.NativeFieldInfoPtr_BeforeFetchFromServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, "BeforeFetchFromServer");
			RemoteSettings.NativeFieldInfoPtr_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, "Completed");
			RemoteSettings.NativeMethodInfoPtr_RemoteSettingsUpdated_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, 100663297);
			RemoteSettings.NativeMethodInfoPtr_RemoteSettingsBeforeFetchFromServer_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, 100663298);
			RemoteSettings.NativeMethodInfoPtr_RemoteSettingsUpdateCompleted_Internal_Static_Void_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, 100663299);
			RemoteSettings.ForceUpdateDelegateField = IL2CPP.ResolveICall<RemoteSettings.ForceUpdateDelegate>("UnityEngine.RemoteSettings::ForceUpdate");
			RemoteSettings.WasLastUpdatedFromServerDelegateField = IL2CPP.ResolveICall<RemoteSettings.WasLastUpdatedFromServerDelegate>("UnityEngine.RemoteSettings::WasLastUpdatedFromServer");
			RemoteSettings.GetIntDelegateField = IL2CPP.ResolveICall<RemoteSettings.GetIntDelegate>("UnityEngine.RemoteSettings::GetInt");
			RemoteSettings.GetLongDelegateField = IL2CPP.ResolveICall<RemoteSettings.GetLongDelegate>("UnityEngine.RemoteSettings::GetLong");
			RemoteSettings.GetFloatDelegateField = IL2CPP.ResolveICall<RemoteSettings.GetFloatDelegate>("UnityEngine.RemoteSettings::GetFloat");
			RemoteSettings.GetStringDelegateField = IL2CPP.ResolveICall<RemoteSettings.GetStringDelegate>("UnityEngine.RemoteSettings::GetString");
			RemoteSettings.GetBoolDelegateField = IL2CPP.ResolveICall<RemoteSettings.GetBoolDelegate>("UnityEngine.RemoteSettings::GetBool");
			RemoteSettings.HasKeyDelegateField = IL2CPP.ResolveICall<RemoteSettings.HasKeyDelegate>("UnityEngine.RemoteSettings::HasKey");
			RemoteSettings.GetCountDelegateField = IL2CPP.ResolveICall<RemoteSettings.GetCountDelegate>("UnityEngine.RemoteSettings::GetCount");
			RemoteSettings.GetKeysDelegateField = IL2CPP.ResolveICall<RemoteSettings.GetKeysDelegate>("UnityEngine.RemoteSettings::GetKeys");
			RemoteSettings.GetAsScriptingObjectDelegateField = IL2CPP.ResolveICall<RemoteSettings.GetAsScriptingObjectDelegate>("UnityEngine.RemoteSettings::GetAsScriptingObject");
			RemoteSettings.UseSafeLockDelegateField = IL2CPP.ResolveICall<RemoteSettings.UseSafeLockDelegate>("UnityEngine.RemoteSettings::UseSafeLock");
			RemoteSettings.ReleaseSafeLockDelegateField = IL2CPP.ResolveICall<RemoteSettings.ReleaseSafeLockDelegate>("UnityEngine.RemoteSettings::ReleaseSafeLock");
			RemoteSettings.GetSafeTopMapDelegateField = IL2CPP.ResolveICall<RemoteSettings.GetSafeTopMapDelegate>("UnityEngine.RemoteSettings::GetSafeTopMap");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002A14 File Offset: 0x00000C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534110, XrefRangeEnd = 534113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wasLastUpdatedFromServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteSettings.NativeMethodInfoPtr_RemoteSettingsUpdated_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002A48 File Offset: 0x00000C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534113, XrefRangeEnd = 534116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoteSettingsBeforeFetchFromServer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteSettings.NativeMethodInfoPtr_RemoteSettingsBeforeFetchFromServer_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002A70 File Offset: 0x00000C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534116, XrefRangeEnd = 534121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wasLastUpdatedFromServer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref settingsChanged;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteSettings.NativeMethodInfoPtr_RemoteSettingsUpdateCompleted_Internal_Static_Void_Boolean_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public RemoteSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static RemoteSettings.UpdatedEventHandler Updated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemoteSettings.NativeFieldInfoPtr_Updated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemoteSettings.UpdatedEventHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteSettings.NativeFieldInfoPtr_Updated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002AE8 File Offset: 0x00000CE8
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe static Action BeforeFetchFromServer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemoteSettings.NativeFieldInfoPtr_BeforeFetchFromServer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteSettings.NativeFieldInfoPtr_BeforeFetchFromServer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002B10 File Offset: 0x00000D10
		// (set) Token: 0x0600000B RID: 11 RVA: 0x0000207D File Offset: 0x0000027D
		public unsafe static Action<bool, bool, int> Completed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemoteSettings.NativeFieldInfoPtr_Completed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteSettings.NativeFieldInfoPtr_Completed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000208F File Offset: 0x0000028F
		public static void add_Updated(RemoteSettings.UpdatedEventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000209C File Offset: 0x0000029C
		public static void remove_Updated(RemoteSettings.UpdatedEventHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020A9 File Offset: 0x000002A9
		public static void CallOnUpdate()
		{
			throw new NotSupportedException("Calling CallOnUpdate() is not necessary any more and should be removed.");
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020B6 File Offset: 0x000002B6
		public static void ForceUpdate()
		{
			RemoteSettings.ForceUpdateDelegateField();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020C2 File Offset: 0x000002C2
		public static bool WasLastUpdatedFromServer()
		{
			return RemoteSettings.WasLastUpdatedFromServerDelegateField();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002B38 File Offset: 0x00000D38
		public static int GetInt(string key)
		{
			return RemoteSettings.GetInt(key, 0);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020CE File Offset: 0x000002CE
		public static int GetInt(string key, int defaultValue)
		{
			return RemoteSettings.GetIntDelegateField(IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002B54 File Offset: 0x00000D54
		public static long GetLong(string key)
		{
			return RemoteSettings.GetLong(key, 0L);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020E1 File Offset: 0x000002E1
		public static long GetLong(string key, long defaultValue)
		{
			return RemoteSettings.GetLongDelegateField(IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002B70 File Offset: 0x00000D70
		public static float GetFloat(string key)
		{
			return RemoteSettings.GetFloat(key, 0f);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020F4 File Offset: 0x000002F4
		public static float GetFloat(string key, float defaultValue)
		{
			return RemoteSettings.GetFloatDelegateField(IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002B90 File Offset: 0x00000D90
		public static string GetString(string key)
		{
			return RemoteSettings.GetString(key, "");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public static string GetString(string key, string defaultValue)
		{
			IntPtr intPtr = RemoteSettings.GetStringDelegateField(IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(defaultValue));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002BDC File Offset: 0x00000DDC
		public static bool GetBool(string key)
		{
			return RemoteSettings.GetBool(key, false);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002107 File Offset: 0x00000307
		public static bool GetBool(string key, bool defaultValue)
		{
			return RemoteSettings.GetBoolDelegateField(IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000211A File Offset: 0x0000031A
		public static bool HasKey(string key)
		{
			return RemoteSettings.HasKeyDelegateField(IL2CPP.ManagedStringToIl2Cpp(key));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000212C File Offset: 0x0000032C
		public static int GetCount()
		{
			return RemoteSettings.GetCountDelegateField();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002BF8 File Offset: 0x00000DF8
		public static Il2CppStringArray GetKeys()
		{
			IntPtr intPtr = RemoteSettings.GetKeysDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C20 File Offset: 0x00000E20
		public static T GetObject<T>([Optional] string key)
		{
			return RemoteSettings.GetObject(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), key).Cast<T>();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002C48 File Offset: 0x00000E48
		public static Object GetObject(Type type, [Optional] string key)
		{
			bool flag = type == null;
			if (flag)
			{
				throw new ArgumentNullException("type");
			}
			bool flag2 = type.IsAbstract || type.IsSubclassOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
			if (flag2)
			{
				throw new ArgumentException(String.Concat("Cannot deserialize to new instances of type '", type.Name, ".'"));
			}
			return RemoteSettings.GetAsScriptingObject(type, null, key);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002CB0 File Offset: 0x00000EB0
		public static Object GetObject(string key, Object defaultValue)
		{
			bool flag = defaultValue == null;
			if (flag)
			{
				throw new ArgumentNullException("defaultValue");
			}
			Type type = defaultValue.GetType();
			bool flag2 = type.IsAbstract || type.IsSubclassOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
			if (flag2)
			{
				throw new ArgumentException(String.Concat("Cannot deserialize to new instances of type '", type.Name, ".'"));
			}
			return RemoteSettings.GetAsScriptingObject(type, defaultValue, key);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002D20 File Offset: 0x00000F20
		public static Object GetAsScriptingObject(Type t, Object defaultValue, string key)
		{
			IntPtr intPtr = RemoteSettings.GetAsScriptingObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtr(t), IL2CPP.Il2CppObjectBaseToPtr(defaultValue), IL2CPP.ManagedStringToIl2Cpp(key));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002D58 File Offset: 0x00000F58
		public static IDictionary<string, Object> GetDictionary([Optional] string key)
		{
			RemoteSettings.UseSafeLock();
			IDictionary<string, Object> dictionary = RemoteConfigSettingsHelper.GetDictionary(RemoteSettings.GetSafeTopMap(), key);
			RemoteSettings.ReleaseSafeLock();
			return dictionary;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002138 File Offset: 0x00000338
		public static void UseSafeLock()
		{
			RemoteSettings.UseSafeLockDelegateField();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002144 File Offset: 0x00000344
		public static void ReleaseSafeLock()
		{
			RemoteSettings.ReleaseSafeLockDelegateField();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002150 File Offset: 0x00000350
		public static IntPtr GetSafeTopMap()
		{
			return RemoteSettings.GetSafeTopMapDelegateField();
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_Updated;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_BeforeFetchFromServer;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_Completed;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_RemoteSettingsUpdated_Internal_Static_Void_Boolean_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_RemoteSettingsBeforeFetchFromServer_Internal_Static_Void_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_RemoteSettingsUpdateCompleted_Internal_Static_Void_Boolean_Boolean_Int32_0;

		// Token: 0x04000007 RID: 7
		private static readonly RemoteSettings.ForceUpdateDelegate ForceUpdateDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly RemoteSettings.WasLastUpdatedFromServerDelegate WasLastUpdatedFromServerDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly RemoteSettings.GetIntDelegate GetIntDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly RemoteSettings.GetLongDelegate GetLongDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly RemoteSettings.GetFloatDelegate GetFloatDelegateField;

		// Token: 0x0400000C RID: 12
		private static readonly RemoteSettings.GetStringDelegate GetStringDelegateField;

		// Token: 0x0400000D RID: 13
		private static readonly RemoteSettings.GetBoolDelegate GetBoolDelegateField;

		// Token: 0x0400000E RID: 14
		private static readonly RemoteSettings.HasKeyDelegate HasKeyDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly RemoteSettings.GetCountDelegate GetCountDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly RemoteSettings.GetKeysDelegate GetKeysDelegateField;

		// Token: 0x04000011 RID: 17
		private static readonly RemoteSettings.GetAsScriptingObjectDelegate GetAsScriptingObjectDelegateField;

		// Token: 0x04000012 RID: 18
		private static readonly RemoteSettings.UseSafeLockDelegate UseSafeLockDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly RemoteSettings.ReleaseSafeLockDelegate ReleaseSafeLockDelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly RemoteSettings.GetSafeTopMapDelegate GetSafeTopMapDelegateField;

		// Token: 0x0200000D RID: 13
		public sealed class UpdatedEventHandler : MulticastDelegate
		{
			// Token: 0x060000DD RID: 221 RVA: 0x0000490C File Offset: 0x00002B0C
			// Note: this type is marked as 'beforefieldinit'.
			static UpdatedEventHandler()
			{
				Il2CppClassPointerStore<RemoteSettings.UpdatedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, "UpdatedEventHandler");
				RemoteSettings.UpdatedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteSettings.UpdatedEventHandler>.NativeClassPtr, 100663300);
				RemoteSettings.UpdatedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteSettings.UpdatedEventHandler>.NativeClassPtr, 100663301);
				RemoteSettings.UpdatedEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteSettings.UpdatedEventHandler>.NativeClassPtr, 100663302);
				RemoteSettings.UpdatedEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteSettings.UpdatedEventHandler>.NativeClassPtr, 100663303);
			}

			// Token: 0x060000DE RID: 222 RVA: 0x00004980 File Offset: 0x00002B80
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdatedEventHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteSettings.UpdatedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteSettings.UpdatedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000DF RID: 223 RVA: 0x000049DC File Offset: 0x00002BDC
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteSettings.UpdatedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000E0 RID: 224 RVA: 0x00004A10 File Offset: 0x00002C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteSettings.UpdatedEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x00004A74 File Offset: 0x00002C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteSettings.UpdatedEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00002808 File Offset: 0x00000A08
			public UpdatedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00002811 File Offset: 0x00000A11
			public static implicit operator RemoteSettings.UpdatedEventHandler(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<RemoteSettings.UpdatedEventHandler>(A_0);
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00002819 File Offset: 0x00000A19
			public static RemoteSettings.UpdatedEventHandler operator +(RemoteSettings.UpdatedEventHandler A_0, RemoteSettings.UpdatedEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RemoteSettings.UpdatedEventHandler>();
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00002827 File Offset: 0x00000A27
			public static RemoteSettings.UpdatedEventHandler operator -(RemoteSettings.UpdatedEventHandler A_0, RemoteSettings.UpdatedEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RemoteSettings.UpdatedEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x04000095 RID: 149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000096 RID: 150
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04000097 RID: 151
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04000098 RID: 152
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x060000E7 RID: 231
		private delegate void ForceUpdateDelegate();

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x060000E9 RID: 233
		private delegate bool WasLastUpdatedFromServerDelegate();

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x060000EB RID: 235
		private delegate int GetIntDelegate(IntPtr key, int defaultValue);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x060000ED RID: 237
		private delegate long GetLongDelegate(IntPtr key, long defaultValue);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x060000EF RID: 239
		private delegate float GetFloatDelegate(IntPtr key, float defaultValue);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060000F1 RID: 241
		private delegate IntPtr GetStringDelegate(IntPtr key, IntPtr defaultValue);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000F3 RID: 243
		private delegate bool GetBoolDelegate(IntPtr key, bool defaultValue);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000F5 RID: 245
		private delegate bool HasKeyDelegate(IntPtr key);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000F7 RID: 247
		private delegate int GetCountDelegate();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000F9 RID: 249
		private delegate IntPtr GetKeysDelegate();

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000FB RID: 251
		private delegate IntPtr GetAsScriptingObjectDelegate(IntPtr t, IntPtr defaultValue, IntPtr key);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000FD RID: 253
		private delegate void UseSafeLockDelegate();

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000FF RID: 255
		private delegate void ReleaseSafeLockDelegate();

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000101 RID: 257
		private delegate IntPtr GetSafeTopMapDelegate();
	}
}
