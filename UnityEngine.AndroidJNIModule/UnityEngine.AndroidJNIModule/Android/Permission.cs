using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Android
{
	// Token: 0x0200000F RID: 15
	[StructLayout(2)]
	public struct Permission
	{
		// Token: 0x060001BE RID: 446 RVA: 0x0000A288 File Offset: 0x00008488
		// Note: this type is marked as 'beforefieldinit'.
		static Permission()
		{
			Il2CppClassPointerStore<Permission>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine.Android", "Permission");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Permission>.NativeClassPtr);
			Permission.NativeFieldInfoPtr_m_Activity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Permission>.NativeClassPtr, "m_Activity");
			Permission.NativeMethodInfoPtr_GetActivity_Internal_Static_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Permission>.NativeClassPtr, 100663547);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000A2E0 File Offset: 0x000084E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 483735, RefRangeEnd = 483736, XrefRangeStart = 483717, XrefRangeEnd = 483735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject GetActivity()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Permission.NativeMethodInfoPtr_GetActivity_Internal_Static_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002756 File Offset: 0x00000956
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Permission>.NativeClassPtr, ref this));
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000A314 File Offset: 0x00008514
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002768 File Offset: 0x00000968
		public unsafe static AndroidJavaObject m_Activity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Permission.NativeFieldInfoPtr_m_Activity, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Permission.NativeFieldInfoPtr_m_Activity, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000277A File Offset: 0x0000097A
		public static AndroidJavaObject GetUnityPermissions()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002787 File Offset: 0x00000987
		public static bool HasUserAuthorizedPermission(string permission)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002794 File Offset: 0x00000994
		public static void RequestUserPermission(string permission)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000A33C File Offset: 0x0000853C
		public static void RequestUserPermissions(Il2CppStringArray permissions)
		{
			bool flag = permissions == null || permissions.Length == 0;
			if (!flag)
			{
				Permission.RequestUserPermissions(permissions, null);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000027A1 File Offset: 0x000009A1
		public static void RequestUserPermission(string permission, PermissionCallbacks callbacks)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000027AE File Offset: 0x000009AE
		public static void RequestUserPermissions(Il2CppStringArray permissions, PermissionCallbacks callbacks)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_m_Activity;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_GetActivity_Internal_Static_AndroidJavaObject_0;

		// Token: 0x04000162 RID: 354
		public const string Camera = "android.permission.CAMERA";

		// Token: 0x04000163 RID: 355
		public const string Microphone = "android.permission.RECORD_AUDIO";

		// Token: 0x04000164 RID: 356
		public const string FineLocation = "android.permission.ACCESS_FINE_LOCATION";

		// Token: 0x04000165 RID: 357
		public const string CoarseLocation = "android.permission.ACCESS_COARSE_LOCATION";

		// Token: 0x04000166 RID: 358
		public const string ExternalStorageRead = "android.permission.READ_EXTERNAL_STORAGE";

		// Token: 0x04000167 RID: 359
		public const string ExternalStorageWrite = "android.permission.WRITE_EXTERNAL_STORAGE";
	}
}
