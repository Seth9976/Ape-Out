using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;

namespace Il2CppRewired.HID
{
	// Token: 0x0200011F RID: 287
	public class HIDHat : HIDControllerElement
	{
		// Token: 0x06001D6C RID: 7532 RVA: 0x0009C710 File Offset: 0x0009A910
		// Note: this type is marked as 'beforefieldinit'.
		static HIDHat()
		{
			Il2CppClassPointerStore<HIDHat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "HIDHat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDHat>.NativeClassPtr);
			HIDHat.NativeFieldInfoPtr_rawValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDHat>.NativeClassPtr, "rawValue");
			HIDHat.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDHat>.NativeClassPtr, "timestamp");
			HIDHat.NativeFieldInfoPtr_byteLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDHat>.NativeClassPtr, "byteLength");
			HIDHat.NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDHat>.NativeClassPtr, "startIndex");
			HIDHat.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDHat>.NativeClassPtr, "type");
			HIDHat.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDHat>.NativeClassPtr, "afkGLXHGxIeTZtbNvjRtofPdBs");
			HIDHat.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDHat>.NativeClassPtr, 100669766);
			HIDHat.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Func_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDHat>.NativeClassPtr, 100669767);
			HIDHat.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDHat>.NativeClassPtr, 100669768);
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x0009C7F4 File Offset: 0x0009A9F4
		[CallerCount(0)]
		public unsafe HIDHat(byte reportId, HIDControllerElement.HIDInfo hidInfo, HIDHat.Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDHat>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reportId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hidInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDHat.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0009C85C File Offset: 0x0009AA5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280566, RefRangeEnd = 280568, XrefRangeStart = 280565, XrefRangeEnd = 280566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDHat(byte reportId, HIDControllerElement.HIDInfo hidInfo, Func<int, int> calcValueDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HIDHat>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reportId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hidInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(calcValueDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HIDHat.NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Func_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0009C8C8 File Offset: 0x0009AAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280568, XrefRangeEnd = 280575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateValue(NativeBuffer inputReport, double timestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputReport);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HIDHat.NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0000C247 File Offset: 0x0000A447
		public HIDHat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x0009C924 File Offset: 0x0009AB24
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x0000C250 File Offset: 0x0000A450
		public unsafe int rawValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_rawValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_rawValue)) = value;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0009C94C File Offset: 0x0009AB4C
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0000C26B File Offset: 0x0000A46B
		public unsafe double timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_timestamp)) = value;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x0009C974 File Offset: 0x0009AB74
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x0000C286 File Offset: 0x0000A486
		public unsafe int byteLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_byteLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_byteLength)) = value;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x0009C99C File Offset: 0x0009AB9C
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x0000C2A1 File Offset: 0x0000A4A1
		public unsafe int startIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_startIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_startIndex)) = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x0009C9C4 File Offset: 0x0009ABC4
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x0000C2BC File Offset: 0x0000A4BC
		public unsafe HIDHat.Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x0009C9EC File Offset: 0x0009ABEC
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x0000C2D7 File Offset: 0x0000A4D7
		public unsafe Func<int, int> afkGLXHGxIeTZtbNvjRtofPdBs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HIDHat.NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeFieldInfoPtr_rawValue;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeFieldInfoPtr_timestamp;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeFieldInfoPtr_byteLength;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeFieldInfoPtr_startIndex;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeFieldInfoPtr_afkGLXHGxIeTZtbNvjRtofPdBs;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Type_0;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_HIDInfo_Func_2_Int32_Int32_0;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Public_Virtual_Void_NativeBuffer_Double_0;

		// Token: 0x02000336 RID: 822
		[OriginalName("Rewired_Core.dll", "", "Type")]
		public enum Type
		{
			// Token: 0x040038E6 RID: 14566
			fdOIlZoUNGDTivZiqDpCzZoybjA,
			// Token: 0x040038E7 RID: 14567
			GvNIhQZLDBHVQXpCefCrEeUTaGo
		}
	}
}
