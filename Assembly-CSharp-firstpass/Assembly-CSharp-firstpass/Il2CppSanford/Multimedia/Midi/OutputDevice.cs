using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x0200019D RID: 413
	public sealed class OutputDevice : OutputDeviceBase
	{
		// Token: 0x06001382 RID: 4994 RVA: 0x0005B180 File Offset: 0x00059380
		// Note: this type is marked as 'beforefieldinit'.
		static OutputDevice()
		{
			Il2CppClassPointerStore<OutputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "OutputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr);
			OutputDevice.NativeFieldInfoPtr_midiOutProc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, "midiOutProc");
			OutputDevice.NativeFieldInfoPtr_runningStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, "runningStatusEnabled");
			OutputDevice.NativeFieldInfoPtr_runningStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, "runningStatus");
			OutputDevice.NativeMethodInfoPtr_midiOutOpen_Private_Static_Int32_byref_IntPtr_Int32_MidiOutProc_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666077);
			OutputDevice.NativeMethodInfoPtr_midiOutClose_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666078);
			OutputDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666079);
			OutputDevice.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666080);
			OutputDevice.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666081);
			OutputDevice.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666082);
			OutputDevice.NativeMethodInfoPtr_Send_Public_Virtual_Void_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666083);
			OutputDevice.NativeMethodInfoPtr_Send_Public_Virtual_Void_SysExMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666084);
			OutputDevice.NativeMethodInfoPtr_Send_Public_Virtual_Void_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666085);
			OutputDevice.NativeMethodInfoPtr_get_RunningStatusEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666086);
			OutputDevice.NativeMethodInfoPtr_set_RunningStatusEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr, 100666087);
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0005B2C8 File Offset: 0x000594C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15567, XrefRangeEnd = 15569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiOutOpen(out IntPtr handle, int deviceID, OutputDeviceBase.MidiOutProc proc, IntPtr instance, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proc);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr_midiOutOpen_Private_Static_Int32_byref_IntPtr_Int32_MidiOutProc_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0005B344 File Offset: 0x00059544
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15571, RefRangeEnd = 15573, XrefRangeStart = 15569, XrefRangeEnd = 15571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiOutClose(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr_midiOutClose_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0005B384 File Offset: 0x00059584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15573, XrefRangeEnd = 15580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutputDevice(int deviceID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputDevice>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0005B3CC File Offset: 0x000595CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15580, XrefRangeEnd = 15603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0005B40C File Offset: 0x0005960C
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0005B440 File Offset: 0x00059640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15603, XrefRangeEnd = 15612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0005B474 File Offset: 0x00059674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15612, XrefRangeEnd = 15620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Send(ChannelMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr_Send_Public_Virtual_Void_ChannelMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0005B4B8 File Offset: 0x000596B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15620, XrefRangeEnd = 15621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Send(SysExMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr_Send_Public_Virtual_Void_SysExMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0005B4FC File Offset: 0x000596FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15621, XrefRangeEnd = 15631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Send(SysCommonMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr_Send_Public_Virtual_Void_SysCommonMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0005B540 File Offset: 0x00059740
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x0005B57C File Offset: 0x0005977C
		public unsafe bool RunningStatusEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr_get_RunningStatusEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDevice.NativeMethodInfoPtr_set_RunningStatusEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x000080FD File Offset: 0x000062FD
		public OutputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x0005B5BC File Offset: 0x000597BC
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x00008106 File Offset: 0x00006306
		public unsafe OutputDeviceBase.MidiOutProc midiOutProc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDevice.NativeFieldInfoPtr_midiOutProc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutputDeviceBase.MidiOutProc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDevice.NativeFieldInfoPtr_midiOutProc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0005B5EC File Offset: 0x000597EC
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x00008125 File Offset: 0x00006325
		public unsafe bool runningStatusEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDevice.NativeFieldInfoPtr_runningStatusEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDevice.NativeFieldInfoPtr_runningStatusEnabled)) = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0005B614 File Offset: 0x00059814
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x00008140 File Offset: 0x00006340
		public unsafe int runningStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDevice.NativeFieldInfoPtr_runningStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDevice.NativeFieldInfoPtr_runningStatus)) = value;
			}
		}

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeFieldInfoPtr_midiOutProc;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeFieldInfoPtr_runningStatusEnabled;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeFieldInfoPtr_runningStatus;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_midiOutOpen_Private_Static_Int32_byref_IntPtr_Int32_MidiOutProc_IntPtr_Int32_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_midiOutClose_Private_Static_Int32_IntPtr_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_ChannelMessage_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_SysExMessage_0;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_SysCommonMessage_0;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr_get_RunningStatusEnabled_Public_get_Boolean_0;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeMethodInfoPtr_set_RunningStatusEnabled_Public_set_Void_Boolean_0;
	}
}
