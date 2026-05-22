using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001B9 RID: 441
	public sealed class MetaMessage : MidiMessageBase
	{
		// Token: 0x0600152A RID: 5418 RVA: 0x000610C4 File Offset: 0x0005F2C4
		// Note: this type is marked as 'beforefieldinit'.
		static MetaMessage()
		{
			Il2CppClassPointerStore<MetaMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "MetaMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr);
			MetaMessage.NativeFieldInfoPtr_Shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, "Shift");
			MetaMessage.NativeFieldInfoPtr_TempoLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, "TempoLength");
			MetaMessage.NativeFieldInfoPtr_SmpteOffsetLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, "SmpteOffsetLength");
			MetaMessage.NativeFieldInfoPtr_TimeSigLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, "TimeSigLength");
			MetaMessage.NativeFieldInfoPtr_KeySigLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, "KeySigLength");
			MetaMessage.NativeFieldInfoPtr_EndOfTrackMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, "EndOfTrackMessage");
			MetaMessage.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, "type");
			MetaMessage.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, "data");
			MetaMessage.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, "hashCode");
			MetaMessage.NativeMethodInfoPtr__ctor_Public_Void_MetaType_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666298);
			MetaMessage.NativeMethodInfoPtr_GetBytes_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666299);
			MetaMessage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666300);
			MetaMessage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666301);
			MetaMessage.NativeMethodInfoPtr_CalculateHashCode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666302);
			MetaMessage.NativeMethodInfoPtr_ValidateDataLength_Private_Boolean_MetaType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666303);
			MetaMessage.NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666304);
			MetaMessage.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666305);
			MetaMessage.NativeMethodInfoPtr_get_MetaType_Public_get_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666306);
			MetaMessage.NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666307);
			MetaMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_Final_New_get_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr, 100666308);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00061284 File Offset: 0x0005F484
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 16491, RefRangeEnd = 16496, XrefRangeStart = 16480, XrefRangeEnd = 16491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaMessage(MetaType type, Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr__ctor_Public_Void_MetaType_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000612E0 File Offset: 0x0005F4E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 16499, RefRangeEnd = 16504, XrefRangeStart = 16496, XrefRangeEnd = 16499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr_GetBytes_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00061320 File Offset: 0x0005F520
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0006135C File Offset: 0x0005F55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16504, XrefRangeEnd = 16510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x000613AC File Offset: 0x0005F5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16510, XrefRangeEnd = 16513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr_CalculateHashCode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000613E0 File Offset: 0x0005F5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16513, XrefRangeEnd = 16517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateDataLength(MetaType type, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr_ValidateDataLength_Private_Boolean_MetaType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000428 RID: 1064
		public unsafe byte this[int index]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 16517, RefRangeEnd = 16523, XrefRangeStart = 16517, XrefRangeEnd = 16517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x00061484 File Offset: 0x0005F684
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x000614C0 File Offset: 0x0005F6C0
		public unsafe MetaType MetaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr_get_MetaType_Public_get_MetaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x000614FC File Offset: 0x0005F6FC
		public unsafe int Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x00061538 File Offset: 0x0005F738
		public unsafe MessageType MessageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_Final_New_get_MessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000089A4 File Offset: 0x00006BA4
		public MetaMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x00061574 File Offset: 0x0005F774
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x000089AD File Offset: 0x00006BAD
		public unsafe static int Shift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MetaMessage.NativeFieldInfoPtr_Shift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MetaMessage.NativeFieldInfoPtr_Shift, (void*)(&value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x00061590 File Offset: 0x0005F790
		// (set) Token: 0x0600153A RID: 5434 RVA: 0x000089BB File Offset: 0x00006BBB
		public unsafe static int TempoLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MetaMessage.NativeFieldInfoPtr_TempoLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MetaMessage.NativeFieldInfoPtr_TempoLength, (void*)(&value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x000615AC File Offset: 0x0005F7AC
		// (set) Token: 0x0600153C RID: 5436 RVA: 0x000089C9 File Offset: 0x00006BC9
		public unsafe static int SmpteOffsetLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MetaMessage.NativeFieldInfoPtr_SmpteOffsetLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MetaMessage.NativeFieldInfoPtr_SmpteOffsetLength, (void*)(&value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x000615C8 File Offset: 0x0005F7C8
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x000089D7 File Offset: 0x00006BD7
		public unsafe static int TimeSigLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MetaMessage.NativeFieldInfoPtr_TimeSigLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MetaMessage.NativeFieldInfoPtr_TimeSigLength, (void*)(&value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x000615E4 File Offset: 0x0005F7E4
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x000089E5 File Offset: 0x00006BE5
		public unsafe static int KeySigLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MetaMessage.NativeFieldInfoPtr_KeySigLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MetaMessage.NativeFieldInfoPtr_KeySigLength, (void*)(&value));
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00061600 File Offset: 0x0005F800
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x000089F3 File Offset: 0x00006BF3
		public unsafe static MetaMessage EndOfTrackMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MetaMessage.NativeFieldInfoPtr_EndOfTrackMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MetaMessage.NativeFieldInfoPtr_EndOfTrackMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x00061628 File Offset: 0x0005F828
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x00008A05 File Offset: 0x00006C05
		public unsafe MetaType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaMessage.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaMessage.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x00061650 File Offset: 0x0005F850
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x00008A20 File Offset: 0x00006C20
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaMessage.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaMessage.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x00061680 File Offset: 0x0005F880
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x00008A3F File Offset: 0x00006C3F
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaMessage.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaMessage.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeFieldInfoPtr_Shift;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeFieldInfoPtr_TempoLength;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeFieldInfoPtr_SmpteOffsetLength;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeFieldInfoPtr_TimeSigLength;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeFieldInfoPtr_KeySigLength;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeFieldInfoPtr_EndOfTrackMessage;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MetaType_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_CalculateHashCode_Private_Void_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDataLength_Private_Boolean_MetaType_Int32_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_get_MetaType_Public_get_MetaType_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageType_Public_Virtual_Final_New_get_MessageType_0;
	}
}
