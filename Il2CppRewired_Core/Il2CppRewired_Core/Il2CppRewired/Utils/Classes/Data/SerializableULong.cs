using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001C6 RID: 454
	[Serializable]
	public class SerializableULong : Object
	{
		// Token: 0x06002FB6 RID: 12214 RVA: 0x000ED5A4 File Offset: 0x000EB7A4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableULong()
		{
			Il2CppClassPointerStore<SerializableULong>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "SerializableULong");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr);
			SerializableULong.NativeFieldInfoPtr_ulong_32BitLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr, "ulong_32BitLow");
			SerializableULong.NativeFieldInfoPtr_ulong_32BitHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr, "ulong_32BitHigh");
			SerializableULong.NativeMethodInfoPtr_get_value_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr, 100675525);
			SerializableULong.NativeMethodInfoPtr_set_value_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr, 100675526);
			SerializableULong.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr, 100675527);
			SerializableULong.NativeMethodInfoPtr__ctor_Public_Void_SerializableULong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr, 100675528);
			SerializableULong.NativeMethodInfoPtr_MdNSycWwhpgQUzqcvjehdFDfqgC_Private_Void_UInt64_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr, 100675529);
			SerializableULong.NativeMethodInfoPtr_dsawgeOHKtElMkoWvqBNswqODJJc_Private_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr, 100675530);
			SerializableULong.NativeMethodInfoPtr_Clone_Public_SerializableULong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr, 100675531);
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x000ED688 File Offset: 0x000EB888
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x000ED6C4 File Offset: 0x000EB8C4
		public unsafe ulong value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableULong.NativeMethodInfoPtr_get_value_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableULong.NativeMethodInfoPtr_set_value_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x000ED704 File Offset: 0x000EB904
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableULong()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableULong.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x000ED740 File Offset: 0x000EB940
		[CallerCount(0)]
		public unsafe SerializableULong(SerializableULong sULong)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableULong>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sULong);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableULong.NativeMethodInfoPtr__ctor_Public_Void_SerializableULong_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x000ED78C File Offset: 0x000EB98C
		[CallerCount(0)]
		public unsafe void MdNSycWwhpgQUzqcvjehdFDfqgC(ulong A_1, out int A_2, out int A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableULong.NativeMethodInfoPtr_MdNSycWwhpgQUzqcvjehdFDfqgC_Private_Void_UInt64_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x000ED7E8 File Offset: 0x000EB9E8
		[CallerCount(0)]
		public unsafe ulong dsawgeOHKtElMkoWvqBNswqODJJc(int A_1, int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableULong.NativeMethodInfoPtr_dsawgeOHKtElMkoWvqBNswqODJJc_Private_UInt64_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x000ED840 File Offset: 0x000EBA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335095, XrefRangeEnd = 335098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableULong Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableULong.NativeMethodInfoPtr_Clone_Public_SerializableULong_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableULong>(intPtr3) : null;
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x000115DC File Offset: 0x0000F7DC
		public SerializableULong(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x000ED880 File Offset: 0x000EBA80
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x000115E5 File Offset: 0x0000F7E5
		public unsafe int ulong_32BitLow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableULong.NativeFieldInfoPtr_ulong_32BitLow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableULong.NativeFieldInfoPtr_ulong_32BitLow)) = value;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x000ED8A8 File Offset: 0x000EBAA8
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x00011600 File Offset: 0x0000F800
		public unsafe int ulong_32BitHigh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableULong.NativeFieldInfoPtr_ulong_32BitHigh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableULong.NativeFieldInfoPtr_ulong_32BitHigh)) = value;
			}
		}

		// Token: 0x0400285F RID: 10335
		private static readonly IntPtr NativeFieldInfoPtr_ulong_32BitLow;

		// Token: 0x04002860 RID: 10336
		private static readonly IntPtr NativeFieldInfoPtr_ulong_32BitHigh;

		// Token: 0x04002861 RID: 10337
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_UInt64_0;

		// Token: 0x04002862 RID: 10338
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_UInt64_0;

		// Token: 0x04002863 RID: 10339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002864 RID: 10340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializableULong_0;

		// Token: 0x04002865 RID: 10341
		private static readonly IntPtr NativeMethodInfoPtr_MdNSycWwhpgQUzqcvjehdFDfqgC_Private_Void_UInt64_byref_Int32_byref_Int32_0;

		// Token: 0x04002866 RID: 10342
		private static readonly IntPtr NativeMethodInfoPtr_dsawgeOHKtElMkoWvqBNswqODJJc_Private_UInt64_Int32_Int32_0;

		// Token: 0x04002867 RID: 10343
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_SerializableULong_0;
	}
}
