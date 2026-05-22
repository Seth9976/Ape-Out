using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Analytics
{
	// Token: 0x02000007 RID: 7
	public static class AnalyticsSessionInfo : Object
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00003778 File Offset: 0x00001978
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsSessionInfo()
		{
			Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine.Analytics", "AnalyticsSessionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr);
			AnalyticsSessionInfo.NativeFieldInfoPtr_sessionStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "sessionStateChanged");
			AnalyticsSessionInfo.NativeFieldInfoPtr_identityTokenChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "identityTokenChanged");
			AnalyticsSessionInfo.NativeMethodInfoPtr_CallSessionStateChanged_Internal_Static_Void_AnalyticsSessionState_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, 100663305);
			AnalyticsSessionInfo.NativeMethodInfoPtr_CallIdentityTokenChanged_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, 100663306);
			AnalyticsSessionInfo.get_sessionStateDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_sessionStateDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionState");
			AnalyticsSessionInfo.get_sessionIdDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_sessionIdDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionId");
			AnalyticsSessionInfo.get_sessionCountDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_sessionCountDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionCount");
			AnalyticsSessionInfo.get_sessionElapsedTimeDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_sessionElapsedTimeDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionElapsedTime");
			AnalyticsSessionInfo.get_sessionFirstRunDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_sessionFirstRunDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionFirstRun");
			AnalyticsSessionInfo.get_userIdDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_userIdDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_userId");
			AnalyticsSessionInfo.get_identityTokenInternalDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_identityTokenInternalDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_identityTokenInternal");
			AnalyticsSessionInfo.get_customUserIdInternalDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_customUserIdInternalDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_customUserIdInternal");
			AnalyticsSessionInfo.set_customUserIdInternalDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.set_customUserIdInternalDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::set_customUserIdInternal");
			AnalyticsSessionInfo.get_customDeviceIdInternalDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_customDeviceIdInternalDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_customDeviceIdInternal");
			AnalyticsSessionInfo.set_customDeviceIdInternalDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.set_customDeviceIdInternalDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::set_customDeviceIdInternal");
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000038A0 File Offset: 0x00001AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534137, XrefRangeEnd = 534140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sessionState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionElapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.NativeMethodInfoPtr_CallSessionStateChanged_Internal_Static_Void_AnalyticsSessionState_Int64_Int64_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000038FC File Offset: 0x00001AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534140, XrefRangeEnd = 534143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallIdentityTokenChanged(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.NativeMethodInfoPtr_CallIdentityTokenChanged_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000024B6 File Offset: 0x000006B6
		public AnalyticsSessionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003934 File Offset: 0x00001B34
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000024BF File Offset: 0x000006BF
		public unsafe static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnalyticsSessionInfo.NativeFieldInfoPtr_sessionStateChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsSessionInfo.SessionStateChanged>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnalyticsSessionInfo.NativeFieldInfoPtr_sessionStateChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000395C File Offset: 0x00001B5C
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000024D1 File Offset: 0x000006D1
		public unsafe static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnalyticsSessionInfo.NativeFieldInfoPtr_identityTokenChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsSessionInfo.IdentityTokenChanged>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnalyticsSessionInfo.NativeFieldInfoPtr_identityTokenChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000024E3 File Offset: 0x000006E3
		public static void add_sessionStateChanged(AnalyticsSessionInfo.SessionStateChanged value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000024F0 File Offset: 0x000006F0
		public static void remove_sessionStateChanged(AnalyticsSessionInfo.SessionStateChanged value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000024FD File Offset: 0x000006FD
		public static AnalyticsSessionState sessionState
		{
			get
			{
				return AnalyticsSessionInfo.get_sessionStateDelegateField();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002509 File Offset: 0x00000709
		public static long sessionId
		{
			get
			{
				return AnalyticsSessionInfo.get_sessionIdDelegateField();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002515 File Offset: 0x00000715
		public static long sessionCount
		{
			get
			{
				return AnalyticsSessionInfo.get_sessionCountDelegateField();
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002521 File Offset: 0x00000721
		public static long sessionElapsedTime
		{
			get
			{
				return AnalyticsSessionInfo.get_sessionElapsedTimeDelegateField();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000252D File Offset: 0x0000072D
		public static bool sessionFirstRun
		{
			get
			{
				return AnalyticsSessionInfo.get_sessionFirstRunDelegateField();
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003984 File Offset: 0x00001B84
		public static string userId
		{
			get
			{
				IntPtr intPtr = AnalyticsSessionInfo.get_userIdDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000039A4 File Offset: 0x00001BA4
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000039CC File Offset: 0x00001BCC
		public static string customUserId
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = null;
				}
				else
				{
					text = AnalyticsSessionInfo.customUserIdInternal;
				}
				return text;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					AnalyticsSessionInfo.customUserIdInternal = value;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000039EC File Offset: 0x00001BEC
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00003A14 File Offset: 0x00001C14
		public static string customDeviceId
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = null;
				}
				else
				{
					text = AnalyticsSessionInfo.customDeviceIdInternal;
				}
				return text;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					AnalyticsSessionInfo.customDeviceIdInternal = value;
				}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002539 File Offset: 0x00000739
		public static void add_identityTokenChanged(AnalyticsSessionInfo.IdentityTokenChanged value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002546 File Offset: 0x00000746
		public static void remove_identityTokenChanged(AnalyticsSessionInfo.IdentityTokenChanged value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003A34 File Offset: 0x00001C34
		public static string identityToken
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = null;
				}
				else
				{
					text = AnalyticsSessionInfo.identityTokenInternal;
				}
				return text;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00003A5C File Offset: 0x00001C5C
		public static string identityTokenInternal
		{
			get
			{
				IntPtr intPtr = AnalyticsSessionInfo.get_identityTokenInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00003A7C File Offset: 0x00001C7C
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002553 File Offset: 0x00000753
		public static string customUserIdInternal
		{
			get
			{
				IntPtr intPtr = AnalyticsSessionInfo.get_customUserIdInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				AnalyticsSessionInfo.set_customUserIdInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00003A9C File Offset: 0x00001C9C
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002565 File Offset: 0x00000765
		public static string customDeviceIdInternal
		{
			get
			{
				IntPtr intPtr = AnalyticsSessionInfo.get_customDeviceIdInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				AnalyticsSessionInfo.set_customDeviceIdInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_sessionStateChanged;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_identityTokenChanged;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_CallSessionStateChanged_Internal_Static_Void_AnalyticsSessionState_Int64_Int64_Boolean_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_CallIdentityTokenChanged_Internal_Static_Void_String_0;

		// Token: 0x04000049 RID: 73
		private static readonly AnalyticsSessionInfo.get_sessionStateDelegate get_sessionStateDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly AnalyticsSessionInfo.get_sessionIdDelegate get_sessionIdDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly AnalyticsSessionInfo.get_sessionCountDelegate get_sessionCountDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly AnalyticsSessionInfo.get_sessionElapsedTimeDelegate get_sessionElapsedTimeDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly AnalyticsSessionInfo.get_sessionFirstRunDelegate get_sessionFirstRunDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly AnalyticsSessionInfo.get_userIdDelegate get_userIdDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly AnalyticsSessionInfo.get_identityTokenInternalDelegate get_identityTokenInternalDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly AnalyticsSessionInfo.get_customUserIdInternalDelegate get_customUserIdInternalDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly AnalyticsSessionInfo.set_customUserIdInternalDelegate set_customUserIdInternalDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly AnalyticsSessionInfo.get_customDeviceIdInternalDelegate get_customDeviceIdInternalDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly AnalyticsSessionInfo.set_customDeviceIdInternalDelegate set_customDeviceIdInternalDelegateField;

		// Token: 0x02000045 RID: 69
		public sealed class SessionStateChanged : MulticastDelegate
		{
			// Token: 0x06000152 RID: 338 RVA: 0x00004AB8 File Offset: 0x00002CB8
			// Note: this type is marked as 'beforefieldinit'.
			static SessionStateChanged()
			{
				Il2CppClassPointerStore<AnalyticsSessionInfo.SessionStateChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "SessionStateChanged");
				AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.SessionStateChanged>.NativeClassPtr, 100663307);
				AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnalyticsSessionState_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.SessionStateChanged>.NativeClassPtr, 100663308);
				AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AnalyticsSessionState_Int64_Int64_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.SessionStateChanged>.NativeClassPtr, 100663309);
				AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.SessionStateChanged>.NativeClassPtr, 100663310);
			}

			// Token: 0x06000153 RID: 339 RVA: 0x00004B2C File Offset: 0x00002D2C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SessionStateChanged(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsSessionInfo.SessionStateChanged>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000154 RID: 340 RVA: 0x00004B88 File Offset: 0x00002D88
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 534124, RefRangeEnd = 534125, XrefRangeStart = 534124, XrefRangeEnd = 534124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sessionState;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionElapsedTime;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnalyticsSessionState_Int64_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000155 RID: 341 RVA: 0x00004BF0 File Offset: 0x00002DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534125, XrefRangeEnd = 534137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sessionState;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionElapsedTime;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionChanged;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AnalyticsSessionState_Int64_Int64_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000156 RID: 342 RVA: 0x00004C8C File Offset: 0x00002E8C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000157 RID: 343 RVA: 0x00002838 File Offset: 0x00000A38
			public SessionStateChanged(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000158 RID: 344 RVA: 0x00002841 File Offset: 0x00000A41
			public static implicit operator AnalyticsSessionInfo.SessionStateChanged(Action<AnalyticsSessionState, long, long, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<AnalyticsSessionInfo.SessionStateChanged>(A_0);
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00002849 File Offset: 0x00000A49
			public static AnalyticsSessionInfo.SessionStateChanged operator +(AnalyticsSessionInfo.SessionStateChanged A_0, AnalyticsSessionInfo.SessionStateChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AnalyticsSessionInfo.SessionStateChanged>();
			}

			// Token: 0x0600015A RID: 346 RVA: 0x00002857 File Offset: 0x00000A57
			public static AnalyticsSessionInfo.SessionStateChanged operator -(AnalyticsSessionInfo.SessionStateChanged A_0, AnalyticsSessionInfo.SessionStateChanged A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AnalyticsSessionInfo.SessionStateChanged>();
				}
				return delegate2;
			}

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnalyticsSessionState_Int64_Int64_Boolean_0;

			// Token: 0x040000A7 RID: 167
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AnalyticsSessionState_Int64_Int64_Boolean_AsyncCallback_Object_0;

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000046 RID: 70
		public sealed class IdentityTokenChanged : MulticastDelegate
		{
			// Token: 0x0600015B RID: 347 RVA: 0x00004CD0 File Offset: 0x00002ED0
			// Note: this type is marked as 'beforefieldinit'.
			static IdentityTokenChanged()
			{
				Il2CppClassPointerStore<AnalyticsSessionInfo.IdentityTokenChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "IdentityTokenChanged");
				AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.IdentityTokenChanged>.NativeClassPtr, 100663311);
				AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.IdentityTokenChanged>.NativeClassPtr, 100663312);
				AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.IdentityTokenChanged>.NativeClassPtr, 100663313);
				AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.IdentityTokenChanged>.NativeClassPtr, 100663314);
			}

			// Token: 0x0600015C RID: 348 RVA: 0x00004D44 File Offset: 0x00002F44
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IdentityTokenChanged(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsSessionInfo.IdentityTokenChanged>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00004DA0 File Offset: 0x00002FA0
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 14114, RefRangeEnd = 14213, XrefRangeStart = 14114, XrefRangeEnd = 14213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string token)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015E RID: 350 RVA: 0x00004DE4 File Offset: 0x00002FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string token, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600015F RID: 351 RVA: 0x00004E58 File Offset: 0x00003058
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00002868 File Offset: 0x00000A68
			public IdentityTokenChanged(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000161 RID: 353 RVA: 0x00002871 File Offset: 0x00000A71
			public static implicit operator AnalyticsSessionInfo.IdentityTokenChanged(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<AnalyticsSessionInfo.IdentityTokenChanged>(A_0);
			}

			// Token: 0x06000162 RID: 354 RVA: 0x00002879 File Offset: 0x00000A79
			public static AnalyticsSessionInfo.IdentityTokenChanged operator +(AnalyticsSessionInfo.IdentityTokenChanged A_0, AnalyticsSessionInfo.IdentityTokenChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AnalyticsSessionInfo.IdentityTokenChanged>();
			}

			// Token: 0x06000163 RID: 355 RVA: 0x00002887 File Offset: 0x00000A87
			public static AnalyticsSessionInfo.IdentityTokenChanged operator -(AnalyticsSessionInfo.IdentityTokenChanged A_0, AnalyticsSessionInfo.IdentityTokenChanged A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AnalyticsSessionInfo.IdentityTokenChanged>();
				}
				return delegate2;
			}

			// Token: 0x040000A9 RID: 169
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x040000AC RID: 172
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000165 RID: 357
		private delegate AnalyticsSessionState get_sessionStateDelegate();

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000167 RID: 359
		private delegate long get_sessionIdDelegate();

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000169 RID: 361
		private delegate long get_sessionCountDelegate();

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600016B RID: 363
		private delegate long get_sessionElapsedTimeDelegate();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600016D RID: 365
		private delegate bool get_sessionFirstRunDelegate();

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x0600016F RID: 367
		private delegate IntPtr get_userIdDelegate();

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000171 RID: 369
		private delegate IntPtr get_identityTokenInternalDelegate();

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000173 RID: 371
		private delegate IntPtr get_customUserIdInternalDelegate();

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000175 RID: 373
		private delegate void set_customUserIdInternalDelegate(IntPtr value);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000177 RID: 375
		private delegate IntPtr get_customDeviceIdInternalDelegate();

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x06000179 RID: 377
		private delegate void set_customDeviceIdInternalDelegate(IntPtr value);
	}
}
