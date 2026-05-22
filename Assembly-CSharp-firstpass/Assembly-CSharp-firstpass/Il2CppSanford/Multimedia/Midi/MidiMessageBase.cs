using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001BE RID: 446
	public class MidiMessageBase : Object
	{
		// Token: 0x06001592 RID: 5522 RVA: 0x00062CB8 File Offset: 0x00060EB8
		// Note: this type is marked as 'beforefieldinit'.
		static MidiMessageBase()
		{
			Il2CppClassPointerStore<MidiMessageBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiMessageBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiMessageBase>.NativeClassPtr);
			MidiMessageBase.NativeFieldInfoPtr__DeltaFrames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiMessageBase>.NativeClassPtr, "<DeltaFrames>k__BackingField");
			MidiMessageBase.NativeMethodInfoPtr_get_DeltaFrames_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiMessageBase>.NativeClassPtr, 100666367);
			MidiMessageBase.NativeMethodInfoPtr_set_DeltaFrames_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiMessageBase>.NativeClassPtr, 100666368);
			MidiMessageBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiMessageBase>.NativeClassPtr, 100666369);
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00062D38 File Offset: 0x00060F38
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x00062D74 File Offset: 0x00060F74
		public unsafe virtual int DeltaFrames
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiMessageBase.NativeMethodInfoPtr_get_DeltaFrames_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiMessageBase.NativeMethodInfoPtr_set_DeltaFrames_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00062DB4 File Offset: 0x00060FB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MidiMessageBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiMessageBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiMessageBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00008AFA File Offset: 0x00006CFA
		public MidiMessageBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00062DF0 File Offset: 0x00060FF0
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x00008B03 File Offset: 0x00006D03
		public unsafe int _DeltaFrames_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiMessageBase.NativeFieldInfoPtr__DeltaFrames_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiMessageBase.NativeFieldInfoPtr__DeltaFrames_k__BackingField)) = value;
			}
		}

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeFieldInfoPtr__DeltaFrames_k__BackingField;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_get_DeltaFrames_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_set_DeltaFrames_Public_set_Void_Int32_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
