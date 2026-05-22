using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001CE RID: 462
	public class MidiFileProperties : Object
	{
		// Token: 0x06001650 RID: 5712 RVA: 0x00065470 File Offset: 0x00063670
		// Note: this type is marked as 'beforefieldinit'.
		static MidiFileProperties()
		{
			Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MidiFileProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr);
			MidiFileProperties.NativeFieldInfoPtr_PropertyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, "PropertyLength");
			MidiFileProperties.NativeFieldInfoPtr_MidiFileHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, "MidiFileHeader");
			MidiFileProperties.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, "format");
			MidiFileProperties.NativeFieldInfoPtr_trackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, "trackCount");
			MidiFileProperties.NativeFieldInfoPtr_division = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, "division");
			MidiFileProperties.NativeFieldInfoPtr_sequenceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, "sequenceType");
			MidiFileProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666449);
			MidiFileProperties.NativeMethodInfoPtr_Read_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666450);
			MidiFileProperties.NativeMethodInfoPtr_FindHeader_Private_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666451);
			MidiFileProperties.NativeMethodInfoPtr_ReadProperty_Private_UInt16_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666452);
			MidiFileProperties.NativeMethodInfoPtr_Write_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666453);
			MidiFileProperties.NativeMethodInfoPtr_WriteProperty_Private_Void_Stream_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666454);
			MidiFileProperties.NativeMethodInfoPtr_IsSmpte_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666455);
			MidiFileProperties.NativeMethodInfoPtr_AssertValid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666456);
			MidiFileProperties.NativeMethodInfoPtr_get_Format_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666457);
			MidiFileProperties.NativeMethodInfoPtr_set_Format_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666458);
			MidiFileProperties.NativeMethodInfoPtr_get_TrackCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666459);
			MidiFileProperties.NativeMethodInfoPtr_set_TrackCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666460);
			MidiFileProperties.NativeMethodInfoPtr_get_Division_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666461);
			MidiFileProperties.NativeMethodInfoPtr_set_Division_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666462);
			MidiFileProperties.NativeMethodInfoPtr_get_SequenceType_Public_get_SequenceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr, 100666463);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00065644 File Offset: 0x00063844
		[CallerCount(0)]
		public unsafe MidiFileProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MidiFileProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00065680 File Offset: 0x00063880
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 17152, RefRangeEnd = 17155, XrefRangeStart = 17127, XrefRangeEnd = 17152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(Stream strm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_Read_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000656C4 File Offset: 0x000638C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17155, XrefRangeEnd = 17156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindHeader(Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_FindHeader_Private_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00065708 File Offset: 0x00063908
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 17184, RefRangeEnd = 17187, XrefRangeStart = 17156, XrefRangeEnd = 17184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort ReadProperty(Stream strm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_ReadProperty_Private_UInt16_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00065758 File Offset: 0x00063958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 17201, RefRangeEnd = 17203, XrefRangeStart = 17187, XrefRangeEnd = 17201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(Stream strm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_Write_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0006579C File Offset: 0x0006399C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 17216, RefRangeEnd = 17219, XrefRangeStart = 17203, XrefRangeEnd = 17216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteProperty(Stream strm, ushort property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_WriteProperty_Private_Void_Stream_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x000657EC File Offset: 0x000639EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 17229, RefRangeEnd = 17231, XrefRangeStart = 17219, XrefRangeEnd = 17229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSmpte(int division)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref division;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_IsSmpte_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0006582C File Offset: 0x00063A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17231, XrefRangeEnd = 17235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssertValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_AssertValid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00065860 File Offset: 0x00063A60
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x0006589C File Offset: 0x00063A9C
		public unsafe int Format
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_get_Format_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 17235, RefRangeEnd = 17237, XrefRangeStart = 17235, XrefRangeEnd = 17235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_set_Format_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x000658DC File Offset: 0x00063ADC
		// (set) Token: 0x0600165C RID: 5724 RVA: 0x00065918 File Offset: 0x00063B18
		public unsafe int TrackCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_get_TrackCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 17237, RefRangeEnd = 17241, XrefRangeStart = 17237, XrefRangeEnd = 17237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_set_TrackCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x00065958 File Offset: 0x00063B58
		// (set) Token: 0x0600165E RID: 5726 RVA: 0x00065994 File Offset: 0x00063B94
		public unsafe int Division
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_get_Division_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 17256, RefRangeEnd = 17258, XrefRangeStart = 17241, XrefRangeEnd = 17256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_set_Division_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x000659D4 File Offset: 0x00063BD4
		public unsafe SequenceType SequenceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MidiFileProperties.NativeMethodInfoPtr_get_SequenceType_Public_get_SequenceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00008F87 File Offset: 0x00007187
		public MidiFileProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00065A10 File Offset: 0x00063C10
		// (set) Token: 0x06001662 RID: 5730 RVA: 0x00008F90 File Offset: 0x00007190
		public unsafe static int PropertyLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MidiFileProperties.NativeFieldInfoPtr_PropertyLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiFileProperties.NativeFieldInfoPtr_PropertyLength, (void*)(&value));
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x00065A2C File Offset: 0x00063C2C
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x00008F9E File Offset: 0x0000719E
		public unsafe static Il2CppStructArray<byte> MidiFileHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MidiFileProperties.NativeFieldInfoPtr_MidiFileHeader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MidiFileProperties.NativeFieldInfoPtr_MidiFileHeader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00065A54 File Offset: 0x00063C54
		// (set) Token: 0x06001666 RID: 5734 RVA: 0x00008FB0 File Offset: 0x000071B0
		public unsafe int format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFileProperties.NativeFieldInfoPtr_format);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFileProperties.NativeFieldInfoPtr_format)) = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x00065A7C File Offset: 0x00063C7C
		// (set) Token: 0x06001668 RID: 5736 RVA: 0x00008FCB File Offset: 0x000071CB
		public unsafe int trackCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFileProperties.NativeFieldInfoPtr_trackCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFileProperties.NativeFieldInfoPtr_trackCount)) = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00065AA4 File Offset: 0x00063CA4
		// (set) Token: 0x0600166A RID: 5738 RVA: 0x00008FE6 File Offset: 0x000071E6
		public unsafe int division
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFileProperties.NativeFieldInfoPtr_division);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFileProperties.NativeFieldInfoPtr_division)) = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x00065ACC File Offset: 0x00063CCC
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x00009001 File Offset: 0x00007201
		public unsafe SequenceType sequenceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFileProperties.NativeFieldInfoPtr_sequenceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MidiFileProperties.NativeFieldInfoPtr_sequenceType)) = value;
			}
		}

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeFieldInfoPtr_PropertyLength;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeFieldInfoPtr_MidiFileHeader;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeFieldInfoPtr_format;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeFieldInfoPtr_trackCount;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeFieldInfoPtr_division;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeFieldInfoPtr_sequenceType;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_Stream_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_FindHeader_Private_Void_Stream_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_ReadProperty_Private_UInt16_Stream_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_Stream_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_WriteProperty_Private_Void_Stream_UInt16_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_IsSmpte_Private_Static_Boolean_Int32_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr_AssertValid_Private_Void_0;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_get_Int32_0;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeMethodInfoPtr_set_Format_Public_set_Void_Int32_0;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_get_TrackCount_Public_get_Int32_0;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_set_TrackCount_Public_set_Void_Int32_0;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr_get_Division_Public_get_Int32_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr_set_Division_Public_set_Void_Int32_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_get_SequenceType_Public_get_SequenceType_0;
	}
}
