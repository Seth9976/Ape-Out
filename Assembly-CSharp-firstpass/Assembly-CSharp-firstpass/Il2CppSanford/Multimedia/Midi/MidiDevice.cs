using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x02000197 RID: 407
	public class MidiDevice : Device
	{
		// Token: 0x06001321 RID: 4897 RVA: 0x0005A350 File Offset: 0x00058550
		// Note: this type is marked as 'beforefieldinit'.
		static MidiDevice()
		{
			Il2CppClassPointerStore<MidiDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiDevice");
			MidiDevice.NativeFieldInfoPtr_SizeOfMidiHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiDevice>.NativeClassPtr, "SizeOfMidiHeader");
			MidiDevice.NativeMethodInfoPtr_midiConnect_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiDevice>.NativeClassPtr, 100666059);
			MidiDevice.NativeMethodInfoPtr_midiDisconnect_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiDevice>.NativeClassPtr, 100666060);
			MidiDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiDevice>.NativeClassPtr, 100666062);
			MidiDevice.NativeMethodInfoPtr_Connect_Public_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiDevice>.NativeClassPtr, 100666063);
			MidiDevice.NativeMethodInfoPtr_Disconnect_Public_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiDevice>.NativeClassPtr, 100666064);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0005A3F0 File Offset: 0x000585F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15452, XrefRangeEnd = 15454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiConnect(IntPtr handleA, IntPtr handleB, IntPtr reserved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiDevice.NativeMethodInfoPtr_midiConnect_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0005A44C File Offset: 0x0005864C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15454, XrefRangeEnd = 15468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int midiDisconnect(IntPtr handleA, IntPtr handleB, IntPtr reserved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiDevice.NativeMethodInfoPtr_midiDisconnect_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0005A4A8 File Offset: 0x000586A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14088, RefRangeEnd = 14090, XrefRangeStart = 14088, XrefRangeEnd = 14090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiDevice(int deviceID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiDevice>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0005A4F0 File Offset: 0x000586F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15468, XrefRangeEnd = 15474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Connect(IntPtr handleA, IntPtr handleB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiDevice.NativeMethodInfoPtr_Connect_Public_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0005A530 File Offset: 0x00058730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15474, XrefRangeEnd = 15480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Disconnect(IntPtr handleA, IntPtr handleB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiDevice.NativeMethodInfoPtr_Disconnect_Public_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00007D9E File Offset: 0x00005F9E
		public MidiDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x0005A570 File Offset: 0x00058770
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x00007DA7 File Offset: 0x00005FA7
		public unsafe static int SizeOfMidiHeader
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiDevice.NativeFieldInfoPtr_SizeOfMidiHeader, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiDevice.NativeFieldInfoPtr_SizeOfMidiHeader, (void*)(&value));
			}
		}

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeFieldInfoPtr_SizeOfMidiHeader;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr_midiConnect_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeMethodInfoPtr_midiDisconnect_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Static_Void_IntPtr_IntPtr_0;
	}
}
