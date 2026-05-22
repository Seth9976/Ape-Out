using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200000D RID: 13
	public sealed class ControllerAssignmentChangedEventArgs : EventArgs
	{
		// Token: 0x06000052 RID: 82 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerAssignmentChangedEventArgs()
		{
			Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerAssignmentChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr);
			ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_GQXlrxGKQorSnvhHdJjMcoODcI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr, "GQXlrxGKQorSnvhHdJjMcoODcI");
			ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr, "HFDLhMjPFtSioLkrcDMAnXTYLIS");
			ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr, "IfhnTjioRBhbGjEtsghiwZaIQGbU");
			ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr, "YgpbSyKqzywxZrpQdLClhHDXnpw");
			ControllerAssignmentChangedEventArgs.NativeMethodInfoPtr_get_state_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr, 100663320);
			ControllerAssignmentChangedEventArgs.NativeMethodInfoPtr_get_controller_Public_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr, 100663321);
			ControllerAssignmentChangedEventArgs.NativeMethodInfoPtr_get_player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr, 100663322);
			ControllerAssignmentChangedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_ControllerType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr, 100663323);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0002D5C8 File Offset: 0x0002B7C8
		public unsafe bool state
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAssignmentChangedEventArgs.NativeMethodInfoPtr_get_state_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0002D604 File Offset: 0x0002B804
		public unsafe Controller controller
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242916, XrefRangeEnd = 242924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAssignmentChangedEventArgs.NativeMethodInfoPtr_get_controller_Public_get_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0002D644 File Offset: 0x0002B844
		public unsafe Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242924, XrefRangeEnd = 242932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAssignmentChangedEventArgs.NativeMethodInfoPtr_get_player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0002D684 File Offset: 0x0002B884
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 242935, RefRangeEnd = 242943, XrefRangeStart = 242932, XrefRangeEnd = 242935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerAssignmentChangedEventArgs(int playerId, int controllerId, ControllerType controllerType, bool state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerAssignmentChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerAssignmentChangedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_ControllerType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000022F6 File Offset: 0x000004F6
		public ControllerAssignmentChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0002D6F8 File Offset: 0x0002B8F8
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000022FF File Offset: 0x000004FF
		public unsafe bool GQXlrxGKQorSnvhHdJjMcoODcI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_GQXlrxGKQorSnvhHdJjMcoODcI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_GQXlrxGKQorSnvhHdJjMcoODcI)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0002D720 File Offset: 0x0002B920
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000231A File Offset: 0x0000051A
		public unsafe int HFDLhMjPFtSioLkrcDMAnXTYLIS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0002D748 File Offset: 0x0002B948
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002335 File Offset: 0x00000535
		public unsafe int IfhnTjioRBhbGjEtsghiwZaIQGbU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0002D770 File Offset: 0x0002B970
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002350 File Offset: 0x00000550
		public unsafe ControllerType YgpbSyKqzywxZrpQdLClhHDXnpw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerAssignmentChangedEventArgs.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw)) = value;
			}
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_GQXlrxGKQorSnvhHdJjMcoODcI;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_state_Public_get_Boolean_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Public_get_Controller_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Public_get_Player_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_ControllerType_Boolean_0;
	}
}
