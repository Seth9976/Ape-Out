using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Il2CppSanford.Multimedia
{
	// Token: 0x02000180 RID: 384
	public class Device : Object
	{
		// Token: 0x0600111F RID: 4383 RVA: 0x000533CC File Offset: 0x000515CC
		// Note: this type is marked as 'beforefieldinit'.
		static Device()
		{
			Il2CppClassPointerStore<Device>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia", "Device");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Device>.NativeClassPtr);
			Device.NativeFieldInfoPtr_CALLBACK_FUNCTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Device>.NativeClassPtr, "CALLBACK_FUNCTION");
			Device.NativeFieldInfoPtr_CALLBACK_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Device>.NativeClassPtr, "CALLBACK_EVENT");
			Device.NativeFieldInfoPtr_deviceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Device>.NativeClassPtr, "deviceID");
			Device.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Device>.NativeClassPtr, "context");
			Device.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Device>.NativeClassPtr, "disposed");
			Device.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Device>.NativeClassPtr, "Error");
			Device.NativeMethodInfoPtr_add_Error_Public_add_Void_EventHandler_1_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665791);
			Device.NativeMethodInfoPtr_remove_Error_Public_rem_Void_EventHandler_1_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665792);
			Device.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665793);
			Device.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665794);
			Device.NativeMethodInfoPtr_OnError_Protected_Virtual_New_Void_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665795);
			Device.NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665796);
			Device.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665797);
			Device.NativeMethodInfoPtr_get_Handle_Public_Abstract_Virtual_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665798);
			Device.NativeMethodInfoPtr_get_DeviceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665799);
			Device.NativeMethodInfoPtr_get_IsDisposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665800);
			Device.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device>.NativeClassPtr, 100665801);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00053550 File Offset: 0x00051750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14079, XrefRangeEnd = 14082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Error(EventHandler<ErrorEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Device.NativeMethodInfoPtr_add_Error_Public_add_Void_EventHandler_1_ErrorEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00053594 File Offset: 0x00051794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14082, XrefRangeEnd = 14085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Error(EventHandler<ErrorEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Device.NativeMethodInfoPtr_remove_Error_Public_rem_Void_EventHandler_1_ErrorEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x000535D8 File Offset: 0x000517D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14088, RefRangeEnd = 14090, XrefRangeStart = 14085, XrefRangeEnd = 14088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Device(int deviceID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Device>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Device.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00053620 File Offset: 0x00051820
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14094, RefRangeEnd = 14098, XrefRangeStart = 14090, XrefRangeEnd = 14094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Device.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0005366C File Offset: 0x0005186C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14098, XrefRangeEnd = 14106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnError(ErrorEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Device.NativeMethodInfoPtr_OnError_Protected_Virtual_New_Void_ErrorEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x000536BC File Offset: 0x000518BC
		[CallerCount(0)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Device.NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x000536F8 File Offset: 0x000518F8
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Device.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x00053734 File Offset: 0x00051934
		public unsafe virtual IntPtr Handle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Device.NativeMethodInfoPtr_get_Handle_Public_Abstract_Virtual_New_get_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x0005377C File Offset: 0x0005197C
		public unsafe int DeviceID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Device.NativeMethodInfoPtr_get_DeviceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x000537B8 File Offset: 0x000519B8
		public unsafe bool IsDisposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Device.NativeMethodInfoPtr_get_IsDisposed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x000537F4 File Offset: 0x000519F4
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Device.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x000070AD File Offset: 0x000052AD
		public Device(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x00053830 File Offset: 0x00051A30
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x000070B6 File Offset: 0x000052B6
		public unsafe static int CALLBACK_FUNCTION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Device.NativeFieldInfoPtr_CALLBACK_FUNCTION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Device.NativeFieldInfoPtr_CALLBACK_FUNCTION, (void*)(&value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0005384C File Offset: 0x00051A4C
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x000070C4 File Offset: 0x000052C4
		public unsafe static int CALLBACK_EVENT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Device.NativeFieldInfoPtr_CALLBACK_EVENT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Device.NativeFieldInfoPtr_CALLBACK_EVENT, (void*)(&value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x00053868 File Offset: 0x00051A68
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x000070D2 File Offset: 0x000052D2
		public unsafe int deviceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.NativeFieldInfoPtr_deviceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.NativeFieldInfoPtr_deviceID)) = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00053890 File Offset: 0x00051A90
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x000070ED File Offset: 0x000052ED
		public unsafe SynchronizationContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x000538C0 File Offset: 0x00051AC0
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x0000710C File Offset: 0x0000530C
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x000538E8 File Offset: 0x00051AE8
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x00007127 File Offset: 0x00005327
		public unsafe EventHandler<ErrorEventArgs> Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.NativeFieldInfoPtr_Error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<ErrorEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.NativeFieldInfoPtr_Error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeFieldInfoPtr_CALLBACK_FUNCTION;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeFieldInfoPtr_CALLBACK_EVENT;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeFieldInfoPtr_deviceID;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_add_Error_Public_add_Void_EventHandler_1_ErrorEventArgs_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_remove_Error_Public_rem_Void_EventHandler_1_ErrorEventArgs_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_OnError_Protected_Virtual_New_Void_ErrorEventArgs_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Abstract_Virtual_New_get_IntPtr_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceID_Public_get_Int32_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDisposed_Public_get_Boolean_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x02000241 RID: 577
		[ObfuscatedName("Sanford.Multimedia.Device+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06001FCC RID: 8140 RVA: 0x0008C27C File Offset: 0x0008A47C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<Device.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Device>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Device.__c__DisplayClass10_0>.NativeClassPtr);
				Device.__c__DisplayClass10_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Device.__c__DisplayClass10_0>.NativeClassPtr, "handler");
				Device.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Device.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				Device.__c__DisplayClass10_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Device.__c__DisplayClass10_0>.NativeClassPtr, "e");
				Device.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device.__c__DisplayClass10_0>.NativeClassPtr, 100665802);
				Device.__c__DisplayClass10_0.NativeMethodInfoPtr__OnError_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Device.__c__DisplayClass10_0>.NativeClassPtr, 100665803);
			}

			// Token: 0x06001FCD RID: 8141 RVA: 0x0008C30C File Offset: 0x0008A50C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Device.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Device.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FCE RID: 8142 RVA: 0x0008C348 File Offset: 0x0008A548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14075, XrefRangeEnd = 14079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnError_b__0(Object dummy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Device.__c__DisplayClass10_0.NativeMethodInfoPtr__OnError_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FCF RID: 8143 RVA: 0x0000B9C1 File Offset: 0x00009BC1
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x0008C38C File Offset: 0x0008A58C
			// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x0000B9CA File Offset: 0x00009BCA
			public unsafe EventHandler<ErrorEventArgs> handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.__c__DisplayClass10_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<ErrorEventArgs>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.__c__DisplayClass10_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x0008C3BC File Offset: 0x0008A5BC
			// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x0000B9E9 File Offset: 0x00009BE9
			public unsafe Device __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Device>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x0008C3EC File Offset: 0x0008A5EC
			// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x0000BA08 File Offset: 0x00009C08
			public unsafe ErrorEventArgs e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.__c__DisplayClass10_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ErrorEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Device.__c__DisplayClass10_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002001 RID: 8193
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x04002002 RID: 8194
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002003 RID: 8195
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x04002004 RID: 8196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002005 RID: 8197
			private static readonly IntPtr NativeMethodInfoPtr__OnError_b__0_Internal_Void_Object_0;
		}
	}
}
