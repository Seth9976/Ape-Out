using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001C3 RID: 451
	public sealed class SysExMessage : MidiMessageBase
	{
		// Token: 0x060015CF RID: 5583 RVA: 0x00063A84 File Offset: 0x00061C84
		// Note: this type is marked as 'beforefieldinit'.
		static SysExMessage()
		{
			Il2CppClassPointerStore<SysExMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "SysExMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr);
			SysExMessage.NativeFieldInfoPtr_SysExChannelMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, "SysExChannelMaxValue");
			SysExMessage.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, "data");
			SysExMessage.NativeFieldInfoPtr__Timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, "<Timestamp>k__BackingField");
			SysExMessage.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666398);
			SysExMessage.NativeMethodInfoPtr_GetBytes_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666399);
			SysExMessage.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666400);
			SysExMessage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666401);
			SysExMessage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666402);
			SysExMessage.NativeMethodInfoPtr_get_Timestamp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666403);
			SysExMessage.NativeMethodInfoPtr_set_Timestamp_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666404);
			SysExMessage.NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666405);
			SysExMessage.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666406);
			SysExMessage.NativeMethodInfoPtr_get_SysExType_Public_get_SysExType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666407);
			SysExMessage.NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666408);
			SysExMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_Final_New_get_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666409);
			SysExMessage.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr, 100666410);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00063BF4 File Offset: 0x00061DF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 16916, RefRangeEnd = 16919, XrefRangeStart = 16895, XrefRangeEnd = 16916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SysExMessage(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SysExMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00063C40 File Offset: 0x00061E40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16923, RefRangeEnd = 16925, XrefRangeStart = 16919, XrefRangeEnd = 16923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_GetBytes_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00063C80 File Offset: 0x00061E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16925, XrefRangeEnd = 16927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppStructArray<byte> buffer, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00063CD0 File Offset: 0x00061ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16927, XrefRangeEnd = 16932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00063D20 File Offset: 0x00061F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16932, XrefRangeEnd = 16933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x00063D5C File Offset: 0x00061F5C
		// (set) Token: 0x060015D6 RID: 5590 RVA: 0x00063D98 File Offset: 0x00061F98
		public unsafe int Timestamp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_get_Timestamp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_set_Timestamp_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000450 RID: 1104
		public unsafe byte this[int index]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 16933, RefRangeEnd = 16939, XrefRangeStart = 16933, XrefRangeEnd = 16933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00063E24 File Offset: 0x00062024
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x00063E60 File Offset: 0x00062060
		public unsafe SysExType SysExType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_get_SysExType_Public_get_SysExType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x00063E9C File Offset: 0x0006209C
		public unsafe int Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00063ED8 File Offset: 0x000620D8
		public unsafe MessageType MessageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_get_MessageType_Public_Virtual_Final_New_get_MessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00063F14 File Offset: 0x00062114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16939, XrefRangeEnd = 16941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SysExMessage.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00008C02 File Offset: 0x00006E02
		public SysExMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x00063F54 File Offset: 0x00062154
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x00008C0B File Offset: 0x00006E0B
		public unsafe static int SysExChannelMaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SysExMessage.NativeFieldInfoPtr_SysExChannelMaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SysExMessage.NativeFieldInfoPtr_SysExChannelMaxValue, (void*)(&value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x00063F70 File Offset: 0x00062170
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x00008C19 File Offset: 0x00006E19
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysExMessage.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysExMessage.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00063FA0 File Offset: 0x000621A0
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x00008C38 File Offset: 0x00006E38
		public unsafe int _Timestamp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysExMessage.NativeFieldInfoPtr__Timestamp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SysExMessage.NativeFieldInfoPtr__Timestamp_k__BackingField)) = value;
			}
		}

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeFieldInfoPtr_SysExChannelMaxValue;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeFieldInfoPtr__Timestamp_k__BackingField;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeMethodInfoPtr_get_Timestamp_Public_get_Int32_0;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeMethodInfoPtr_set_Timestamp_Internal_set_Void_Int32_0;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr_get_SysExType_Public_get_SysExType_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageType_Public_Virtual_Final_New_get_MessageType_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;
	}
}
