using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSanford.Threading;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x0200019F RID: 415
	public class OutputDeviceBase : MidiDevice
	{
		// Token: 0x0600139C RID: 5020 RVA: 0x0005B7D8 File Offset: 0x000599D8
		// Note: this type is marked as 'beforefieldinit'.
		static OutputDeviceBase()
		{
			Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "OutputDeviceBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr);
			OutputDeviceBase.NativeFieldInfoPtr_MOM_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, "MOM_OPEN");
			OutputDeviceBase.NativeFieldInfoPtr_MOM_CLOSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, "MOM_CLOSE");
			OutputDeviceBase.NativeFieldInfoPtr_MOM_DONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, "MOM_DONE");
			OutputDeviceBase.NativeFieldInfoPtr_delegateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, "delegateQueue");
			OutputDeviceBase.NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, "lockObject");
			OutputDeviceBase.NativeFieldInfoPtr_bufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, "bufferCount");
			OutputDeviceBase.NativeFieldInfoPtr_headerBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, "headerBuilder");
			OutputDeviceBase.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, "handle");
			OutputDeviceBase.NativeMethodInfoPtr_midiOutReset_Protected_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666091);
			OutputDeviceBase.NativeMethodInfoPtr_midiOutShortMsg_Protected_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666092);
			OutputDeviceBase.NativeMethodInfoPtr_midiOutPrepareHeader_Protected_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666093);
			OutputDeviceBase.NativeMethodInfoPtr_midiOutUnprepareHeader_Protected_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666094);
			OutputDeviceBase.NativeMethodInfoPtr_midiOutLongMsg_Protected_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666095);
			OutputDeviceBase.NativeMethodInfoPtr_midiOutGetDevCaps_Protected_Static_Int32_IntPtr_byref_MidiOutCaps_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666096);
			OutputDeviceBase.NativeMethodInfoPtr_midiOutGetNumDevs_Protected_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666097);
			OutputDeviceBase.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666098);
			OutputDeviceBase.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666099);
			OutputDeviceBase.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666100);
			OutputDeviceBase.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_ChannelMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666101);
			OutputDeviceBase.NativeMethodInfoPtr_SendShort_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666102);
			OutputDeviceBase.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SysExMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666103);
			OutputDeviceBase.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SysCommonMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666104);
			OutputDeviceBase.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SysRealtimeMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666105);
			OutputDeviceBase.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666106);
			OutputDeviceBase.NativeMethodInfoPtr_Send_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666107);
			OutputDeviceBase.NativeMethodInfoPtr_GetDeviceCapabilities_Public_Static_MidiOutCaps_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666108);
			OutputDeviceBase.NativeMethodInfoPtr_HandleMessage_Protected_Virtual_New_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666109);
			OutputDeviceBase.NativeMethodInfoPtr_ReleaseBuffer_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666110);
			OutputDeviceBase.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666111);
			OutputDeviceBase.NativeMethodInfoPtr_get_Handle_Public_Virtual_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666112);
			OutputDeviceBase.NativeMethodInfoPtr_get_DeviceCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, 100666113);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0005BA74 File Offset: 0x00059C74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 15663, RefRangeEnd = 15666, XrefRangeStart = 15661, XrefRangeEnd = 15663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiOutReset(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_midiOutReset_Protected_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0005BAB4 File Offset: 0x00059CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15666, XrefRangeEnd = 15668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiOutShortMsg(IntPtr handle, int message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref message;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_midiOutShortMsg_Protected_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0005BB00 File Offset: 0x00059D00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15670, RefRangeEnd = 15672, XrefRangeStart = 15668, XrefRangeEnd = 15670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiOutPrepareHeader(IntPtr handle, IntPtr headerPtr, int sizeOfMidiHeader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfMidiHeader;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_midiOutPrepareHeader_Protected_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0005BB5C File Offset: 0x00059D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15674, RefRangeEnd = 15675, XrefRangeStart = 15672, XrefRangeEnd = 15674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiOutUnprepareHeader(IntPtr handle, IntPtr headerPtr, int sizeOfMidiHeader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfMidiHeader;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_midiOutUnprepareHeader_Protected_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0005BBB8 File Offset: 0x00059DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15675, XrefRangeEnd = 15677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiOutLongMsg(IntPtr handle, IntPtr headerPtr, int sizeOfMidiHeader)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfMidiHeader;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_midiOutLongMsg_Protected_Static_Int32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0005BC14 File Offset: 0x00059E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15680, RefRangeEnd = 15681, XrefRangeStart = 15677, XrefRangeEnd = 15680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiOutGetDevCaps(IntPtr deviceID, ref MidiOutCaps caps, int sizeOfMidiOutCaps)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(caps));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOfMidiOutCaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_midiOutGetDevCaps_Protected_Static_Int32_IntPtr_byref_MidiOutCaps_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0005BC78 File Offset: 0x00059E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15681, XrefRangeEnd = 15683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiOutGetNumDevs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_midiOutGetNumDevs_Protected_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0005BCA8 File Offset: 0x00059EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15699, RefRangeEnd = 15701, XrefRangeStart = 15683, XrefRangeEnd = 15699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutputDeviceBase(int deviceID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0005BCF0 File Offset: 0x00059EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0005BD2C File Offset: 0x00059F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15701, XrefRangeEnd = 15704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0005BD78 File Offset: 0x00059F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15704, XrefRangeEnd = 15714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(ChannelMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_ChannelMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0005BDC8 File Offset: 0x00059FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15714, XrefRangeEnd = 15723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendShort(int message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_SendShort_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0005BE14 File Offset: 0x0005A014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15743, RefRangeEnd = 15744, XrefRangeStart = 15723, XrefRangeEnd = 15743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(SysExMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SysExMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0005BE64 File Offset: 0x0005A064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15744, XrefRangeEnd = 15754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(SysCommonMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SysCommonMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0005BEB4 File Offset: 0x0005A0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15754, XrefRangeEnd = 15764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(SysRealtimeMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SysRealtimeMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0005BF04 File Offset: 0x0005A104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15770, RefRangeEnd = 15772, XrefRangeStart = 15764, XrefRangeEnd = 15770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0005BF40 File Offset: 0x0005A140
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 15777, RefRangeEnd = 15785, XrefRangeStart = 15772, XrefRangeEnd = 15777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Send(int message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_Send_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0005BF80 File Offset: 0x0005A180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15785, XrefRangeEnd = 15798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MidiOutCaps GetDeviceCapabilities(int deviceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_GetDeviceCapabilities_Public_Static_MidiOutCaps_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MidiOutCaps(intPtr);
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0005BFB8 File Offset: 0x0005A1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15798, XrefRangeEnd = 15806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleMessage(IntPtr hnd, int msg, IntPtr instance, IntPtr param1, IntPtr param2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hnd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_HandleMessage_Protected_Virtual_New_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0005C03C File Offset: 0x0005A23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15806, XrefRangeEnd = 15826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseBuffer(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_ReleaseBuffer_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0005C080 File Offset: 0x0005A280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15826, XrefRangeEnd = 15829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0005C0BC File Offset: 0x0005A2BC
		public unsafe override IntPtr Handle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OutputDeviceBase.NativeMethodInfoPtr_get_Handle_Public_Virtual_get_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0005C104 File Offset: 0x0005A304
		public unsafe static int DeviceCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.NativeMethodInfoPtr_get_DeviceCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00008183 File Offset: 0x00006383
		public OutputDeviceBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0005C134 File Offset: 0x0005A334
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x0000818C File Offset: 0x0000638C
		public unsafe static int MOM_OPEN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OutputDeviceBase.NativeFieldInfoPtr_MOM_OPEN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputDeviceBase.NativeFieldInfoPtr_MOM_OPEN, (void*)(&value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0005C150 File Offset: 0x0005A350
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x0000819A File Offset: 0x0000639A
		public unsafe static int MOM_CLOSE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OutputDeviceBase.NativeFieldInfoPtr_MOM_CLOSE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputDeviceBase.NativeFieldInfoPtr_MOM_CLOSE, (void*)(&value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0005C16C File Offset: 0x0005A36C
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x000081A8 File Offset: 0x000063A8
		public unsafe static int MOM_DONE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OutputDeviceBase.NativeFieldInfoPtr_MOM_DONE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OutputDeviceBase.NativeFieldInfoPtr_MOM_DONE, (void*)(&value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x0005C188 File Offset: 0x0005A388
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x000081B6 File Offset: 0x000063B6
		public unsafe DelegateQueue delegateQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceBase.NativeFieldInfoPtr_delegateQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceBase.NativeFieldInfoPtr_delegateQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0005C1B8 File Offset: 0x0005A3B8
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x000081D5 File Offset: 0x000063D5
		public unsafe Object lockObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceBase.NativeFieldInfoPtr_lockObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceBase.NativeFieldInfoPtr_lockObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x0005C1E8 File Offset: 0x0005A3E8
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x000081F4 File Offset: 0x000063F4
		public unsafe int bufferCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceBase.NativeFieldInfoPtr_bufferCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceBase.NativeFieldInfoPtr_bufferCount)) = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0005C210 File Offset: 0x0005A410
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0000820F File Offset: 0x0000640F
		public unsafe MidiHeaderBuilder headerBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceBase.NativeFieldInfoPtr_headerBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MidiHeaderBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceBase.NativeFieldInfoPtr_headerBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0005C240 File Offset: 0x0005A440
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0000822E File Offset: 0x0000642E
		public unsafe IntPtr handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceBase.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutputDeviceBase.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeFieldInfoPtr_MOM_OPEN;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeFieldInfoPtr_MOM_CLOSE;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeFieldInfoPtr_MOM_DONE;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeFieldInfoPtr_delegateQueue;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeFieldInfoPtr_lockObject;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeFieldInfoPtr_bufferCount;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeFieldInfoPtr_headerBuilder;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_midiOutReset_Protected_Static_Int32_IntPtr_0;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_midiOutShortMsg_Protected_Static_Int32_IntPtr_Int32_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr_midiOutPrepareHeader_Protected_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr_midiOutUnprepareHeader_Protected_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr_midiOutLongMsg_Protected_Static_Int32_IntPtr_IntPtr_Int32_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_midiOutGetDevCaps_Protected_Static_Int32_IntPtr_byref_MidiOutCaps_Int32_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_midiOutGetNumDevs_Protected_Static_Int32_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_ChannelMessage_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_SendShort_Public_Virtual_New_Void_Int32_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SysExMessage_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SysCommonMessage_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SysRealtimeMessage_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_Send_Protected_Void_Int32_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceCapabilities_Public_Static_MidiOutCaps_Int32_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_HandleMessage_Protected_Virtual_New_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseBuffer_Private_Void_Object_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Virtual_get_IntPtr_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceCount_Public_Static_get_Int32_0;

		// Token: 0x02000250 RID: 592
		public sealed class GenericDelegate<T> : MulticastDelegate
		{
			// Token: 0x06002059 RID: 8281 RVA: 0x0008DCDC File Offset: 0x0008BEDC
			// Note: this type is marked as 'beforefieldinit'.
			static GenericDelegate()
			{
				Il2CppClassPointerStore<OutputDeviceBase.GenericDelegate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, "GenericDelegate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				OutputDeviceBase.GenericDelegate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase.GenericDelegate<T>>.NativeClassPtr, 100666114);
				OutputDeviceBase.GenericDelegate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase.GenericDelegate<T>>.NativeClassPtr, 100666115);
				OutputDeviceBase.GenericDelegate<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase.GenericDelegate<T>>.NativeClassPtr, 100666116);
				OutputDeviceBase.GenericDelegate<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase.GenericDelegate<T>>.NativeClassPtr, 100666117);
			}

			// Token: 0x0600205A RID: 8282 RVA: 0x0008DD88 File Offset: 0x0008BF88
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GenericDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputDeviceBase.GenericDelegate<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.GenericDelegate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600205B RID: 8283 RVA: 0x0008DDE4 File Offset: 0x0008BFE4
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 14114, RefRangeEnd = 14213, XrefRangeStart = 14114, XrefRangeEnd = 14213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(T args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = args;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref args;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.GenericDelegate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600205C RID: 8284 RVA: 0x0008DE74 File Offset: 0x0008C074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T args, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = args;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref args;
					}
					*ptr2 = ref ptr4;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.GenericDelegate<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600205D RID: 8285 RVA: 0x0008DF34 File Offset: 0x0008C134
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.GenericDelegate<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600205E RID: 8286 RVA: 0x0000BE6B File Offset: 0x0000A06B
			public GenericDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600205F RID: 8287 RVA: 0x0000BE74 File Offset: 0x0000A074
			public static implicit operator OutputDeviceBase.GenericDelegate<T>(Action<T> A_0)
			{
				return DelegateSupport.ConvertDelegate<OutputDeviceBase.GenericDelegate<T>>(A_0);
			}

			// Token: 0x06002060 RID: 8288 RVA: 0x0000BE7C File Offset: 0x0000A07C
			public static OutputDeviceBase.GenericDelegate<T>operator +(OutputDeviceBase.GenericDelegate<T> A_0, OutputDeviceBase.GenericDelegate<T> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OutputDeviceBase.GenericDelegate<T>>();
			}

			// Token: 0x06002061 RID: 8289 RVA: 0x0000BE8A File Offset: 0x0000A08A
			public static OutputDeviceBase.GenericDelegate<T>operator -(OutputDeviceBase.GenericDelegate<T> A_0, OutputDeviceBase.GenericDelegate<T> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OutputDeviceBase.GenericDelegate<T>>();
				}
				return delegate2;
			}

			// Token: 0x04002045 RID: 8261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002046 RID: 8262
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0;

			// Token: 0x04002047 RID: 8263
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

			// Token: 0x04002048 RID: 8264
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000251 RID: 593
		public sealed class MidiOutProc : MulticastDelegate
		{
			// Token: 0x06002062 RID: 8290 RVA: 0x0008DF78 File Offset: 0x0008C178
			// Note: this type is marked as 'beforefieldinit'.
			static MidiOutProc()
			{
				Il2CppClassPointerStore<OutputDeviceBase.MidiOutProc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OutputDeviceBase>.NativeClassPtr, "MidiOutProc");
				OutputDeviceBase.MidiOutProc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase.MidiOutProc>.NativeClassPtr, 100666118);
				OutputDeviceBase.MidiOutProc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase.MidiOutProc>.NativeClassPtr, 100666119);
				OutputDeviceBase.MidiOutProc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase.MidiOutProc>.NativeClassPtr, 100666120);
				OutputDeviceBase.MidiOutProc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputDeviceBase.MidiOutProc>.NativeClassPtr, 100666121);
			}

			// Token: 0x06002063 RID: 8291 RVA: 0x0008DFEC File Offset: 0x0008C1EC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MidiOutProc(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputDeviceBase.MidiOutProc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.MidiOutProc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002064 RID: 8292 RVA: 0x0008E048 File Offset: 0x0008C248
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr hnd, int msg, IntPtr instance, IntPtr param1, IntPtr param2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hnd;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msg;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param1;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.MidiOutProc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002065 RID: 8293 RVA: 0x0008E0C0 File Offset: 0x0008C2C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15648, XrefRangeEnd = 15661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr hnd, int msg, IntPtr instance, IntPtr param1, IntPtr param2, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hnd;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref msg;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param1;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param2;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.MidiOutProc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002066 RID: 8294 RVA: 0x0008E16C File Offset: 0x0008C36C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputDeviceBase.MidiOutProc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002067 RID: 8295 RVA: 0x0000BE9B File Offset: 0x0000A09B
			public MidiOutProc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002068 RID: 8296 RVA: 0x0000BEA4 File Offset: 0x0000A0A4
			public static implicit operator OutputDeviceBase.MidiOutProc(Action<IntPtr, int, IntPtr, IntPtr, IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<OutputDeviceBase.MidiOutProc>(A_0);
			}

			// Token: 0x06002069 RID: 8297 RVA: 0x0000BEAC File Offset: 0x0000A0AC
			public static OutputDeviceBase.MidiOutProc operator +(OutputDeviceBase.MidiOutProc A_0, OutputDeviceBase.MidiOutProc A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OutputDeviceBase.MidiOutProc>();
			}

			// Token: 0x0600206A RID: 8298 RVA: 0x0000BEBA File Offset: 0x0000A0BA
			public static OutputDeviceBase.MidiOutProc operator -(OutputDeviceBase.MidiOutProc A_0, OutputDeviceBase.MidiOutProc A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OutputDeviceBase.MidiOutProc>();
				}
				return delegate2;
			}

			// Token: 0x04002049 RID: 8265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400204A RID: 8266
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_IntPtr_IntPtr_IntPtr_0;

			// Token: 0x0400204B RID: 8267
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0;

			// Token: 0x0400204C RID: 8268
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
