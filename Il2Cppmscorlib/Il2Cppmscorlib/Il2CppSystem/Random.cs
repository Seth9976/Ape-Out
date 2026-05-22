using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000DE RID: 222
	[Serializable]
	public class Random : Object
	{
		// Token: 0x06000EB9 RID: 3769 RVA: 0x00066B40 File Offset: 0x00064D40
		// Note: this type is marked as 'beforefieldinit'.
		static Random()
		{
			Il2CppClassPointerStore<Random>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Random");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random>.NativeClassPtr);
			Random.NativeFieldInfoPtr_MBIG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "MBIG");
			Random.NativeFieldInfoPtr_MSEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "MSEED");
			Random.NativeFieldInfoPtr_MZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "MZ");
			Random.NativeFieldInfoPtr_inext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "inext");
			Random.NativeFieldInfoPtr_inextp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "inextp");
			Random.NativeFieldInfoPtr_SeedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random>.NativeClassPtr, "SeedArray");
			Random.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665796);
			Random.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665797);
			Random.NativeMethodInfoPtr_Sample_Protected_Virtual_New_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665798);
			Random.NativeMethodInfoPtr_InternalSample_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665799);
			Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665800);
			Random.NativeMethodInfoPtr_GetSampleForLargeRange_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665801);
			Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665802);
			Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665803);
			Random.NativeMethodInfoPtr_NextDouble_Public_Virtual_New_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100665804);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00066C9C File Offset: 0x00064E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161348, XrefRangeEnd = 161349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Random()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Random>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00066CD8 File Offset: 0x00064ED8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 161356, RefRangeEnd = 161368, XrefRangeStart = 161349, XrefRangeEnd = 161356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Random(int Seed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Random>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Seed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00066D20 File Offset: 0x00064F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161368, XrefRangeEnd = 161369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double Sample()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Sample_Protected_Virtual_New_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00066D68 File Offset: 0x00064F68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 161369, RefRangeEnd = 161375, XrefRangeStart = 161369, XrefRangeEnd = 161369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalSample()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_InternalSample_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00066DA4 File Offset: 0x00064FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161375, XrefRangeEnd = 161376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00066DEC File Offset: 0x00064FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161376, XrefRangeEnd = 161378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetSampleForLargeRange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_GetSampleForLargeRange_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00066E28 File Offset: 0x00065028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161378, XrefRangeEnd = 161380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Next(int minValue, int maxValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00066E8C File Offset: 0x0006508C
		[CallerCount(0)]
		public unsafe virtual int Next(int maxValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00066EE0 File Offset: 0x000650E0
		[CallerCount(0)]
		public unsafe virtual double NextDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Random.NativeMethodInfoPtr_NextDouble_Public_Virtual_New_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00005C35 File Offset: 0x00003E35
		public Random(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00066F28 File Offset: 0x00065128
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x00005C3E File Offset: 0x00003E3E
		public unsafe static int MBIG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_MBIG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_MBIG, (void*)(&value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00066F44 File Offset: 0x00065144
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00005C4C File Offset: 0x00003E4C
		public unsafe static int MSEED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_MSEED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_MSEED, (void*)(&value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00066F60 File Offset: 0x00065160
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x00005C5A File Offset: 0x00003E5A
		public unsafe static int MZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Random.NativeFieldInfoPtr_MZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Random.NativeFieldInfoPtr_MZ, (void*)(&value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00066F7C File Offset: 0x0006517C
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00005C68 File Offset: 0x00003E68
		public unsafe int inext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_inext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_inext)) = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00066FA4 File Offset: 0x000651A4
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x00005C83 File Offset: 0x00003E83
		public unsafe int inextp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_inextp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_inextp)) = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00066FCC File Offset: 0x000651CC
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00005C9E File Offset: 0x00003E9E
		public unsafe Il2CppStructArray<int> SeedArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_SeedArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Random.NativeFieldInfoPtr_SeedArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeFieldInfoPtr_MBIG;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeFieldInfoPtr_MSEED;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeFieldInfoPtr_MZ;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_inext;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeFieldInfoPtr_inextp;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeFieldInfoPtr_SeedArray;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_Sample_Protected_Virtual_New_Double_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_InternalSample_Private_Int32_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleForLargeRange_Private_Double_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_New_Int32_Int32_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_NextDouble_Public_Virtual_New_Double_0;
	}
}
