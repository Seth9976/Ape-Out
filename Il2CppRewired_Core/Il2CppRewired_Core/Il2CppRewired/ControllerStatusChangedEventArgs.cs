using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200000C RID: 12
	public sealed class ControllerStatusChangedEventArgs : EventArgs
	{
		// Token: 0x06000045 RID: 69 RVA: 0x0002D258 File Offset: 0x0002B458
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerStatusChangedEventArgs()
		{
			Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerStatusChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr);
			ControllerStatusChangedEventArgs.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr, "dBMfgEzHekDWhMsmrRiTWJogtDs");
			ControllerStatusChangedEventArgs.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr, "IfhnTjioRBhbGjEtsghiwZaIQGbU");
			ControllerStatusChangedEventArgs.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr, "YgpbSyKqzywxZrpQdLClhHDXnpw");
			ControllerStatusChangedEventArgs.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr, 100663315);
			ControllerStatusChangedEventArgs.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr, 100663316);
			ControllerStatusChangedEventArgs.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr, 100663317);
			ControllerStatusChangedEventArgs.NativeMethodInfoPtr_get_controller_Public_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr, 100663318);
			ControllerStatusChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr, 100663319);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0002D328 File Offset: 0x0002B528
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerStatusChangedEventArgs.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0002D360 File Offset: 0x0002B560
		public unsafe int controllerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerStatusChangedEventArgs.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0002D39C File Offset: 0x0002B59C
		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerStatusChangedEventArgs.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0002D3D8 File Offset: 0x0002B5D8
		public unsafe Controller controller
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242900, XrefRangeEnd = 242908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerStatusChangedEventArgs.NativeMethodInfoPtr_get_controller_Public_get_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0002D418 File Offset: 0x0002B618
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 242911, RefRangeEnd = 242916, XrefRangeStart = 242908, XrefRangeEnd = 242911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerStatusChangedEventArgs(string name, int uniqueId, ControllerType controllerType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerStatusChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uniqueId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerStatusChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002298 File Offset: 0x00000498
		public ControllerStatusChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0002D480 File Offset: 0x0002B680
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000022A1 File Offset: 0x000004A1
		public unsafe string dBMfgEzHekDWhMsmrRiTWJogtDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerStatusChangedEventArgs.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerStatusChangedEventArgs.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0002D4A8 File Offset: 0x0002B6A8
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000022C0 File Offset: 0x000004C0
		public unsafe int IfhnTjioRBhbGjEtsghiwZaIQGbU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerStatusChangedEventArgs.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerStatusChangedEventArgs.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0002D4D0 File Offset: 0x0002B6D0
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000022DB File Offset: 0x000004DB
		public unsafe ControllerType YgpbSyKqzywxZrpQdLClhHDXnpw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerStatusChangedEventArgs.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerStatusChangedEventArgs.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw)) = value;
			}
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Public_get_Controller_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_ControllerType_0;
	}
}
