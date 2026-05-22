using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000DC RID: 220
	public sealed class ParamsArray : ValueType
	{
		// Token: 0x06000E9D RID: 3741 RVA: 0x00066564 File Offset: 0x00064764
		// Note: this type is marked as 'beforefieldinit'.
		static ParamsArray()
		{
			Il2CppClassPointerStore<ParamsArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParamsArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr);
			ParamsArray.NativeFieldInfoPtr_oneArgArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "oneArgArray");
			ParamsArray.NativeFieldInfoPtr_twoArgArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "twoArgArray");
			ParamsArray.NativeFieldInfoPtr_threeArgArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "threeArgArray");
			ParamsArray.NativeFieldInfoPtr_arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "arg0");
			ParamsArray.NativeFieldInfoPtr_arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "arg1");
			ParamsArray.NativeFieldInfoPtr_arg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "arg2");
			ParamsArray.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "args");
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665786);
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665787);
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665788);
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665789);
			ParamsArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665790);
			ParamsArray.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665791);
			ParamsArray.NativeMethodInfoPtr_GetAtSlow_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665792);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x000666AC File Offset: 0x000648AC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 161256, RefRangeEnd = 161264, XrefRangeStart = 161252, XrefRangeEnd = 161256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Object arg0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000666FC File Offset: 0x000648FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 161268, RefRangeEnd = 161273, XrefRangeStart = 161264, XrefRangeEnd = 161268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Object arg0, Object arg1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00066760 File Offset: 0x00064960
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161277, RefRangeEnd = 161280, XrefRangeStart = 161273, XrefRangeEnd = 161277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Object arg0, Object arg1, Object arg2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000667D4 File Offset: 0x000649D4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 161282, RefRangeEnd = 161291, XrefRangeStart = 161280, XrefRangeEnd = 161282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Il2CppReferenceArray<Object> args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00066824 File Offset: 0x00064A24
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000299 RID: 665
		public unsafe Object this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 161291, RefRangeEnd = 161292, XrefRangeStart = 161291, XrefRangeEnd = 161291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000668BC File Offset: 0x00064ABC
		[CallerCount(0)]
		public unsafe Object GetAtSlow(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr_GetAtSlow_Private_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00005B5F File Offset: 0x00003D5F
		public ParamsArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00005B68 File Offset: 0x00003D68
		public ParamsArray()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00066910 File Offset: 0x00064B10
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x00005B7A File Offset: 0x00003D7A
		public unsafe static Il2CppReferenceArray<Object> oneArgArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParamsArray.NativeFieldInfoPtr_oneArgArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParamsArray.NativeFieldInfoPtr_oneArgArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00066938 File Offset: 0x00064B38
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x00005B8C File Offset: 0x00003D8C
		public unsafe static Il2CppReferenceArray<Object> twoArgArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParamsArray.NativeFieldInfoPtr_twoArgArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParamsArray.NativeFieldInfoPtr_twoArgArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00066960 File Offset: 0x00064B60
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00005B9E File Offset: 0x00003D9E
		public unsafe static Il2CppReferenceArray<Object> threeArgArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParamsArray.NativeFieldInfoPtr_threeArgArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParamsArray.NativeFieldInfoPtr_threeArgArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00066988 File Offset: 0x00064B88
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x00005BB0 File Offset: 0x00003DB0
		public unsafe Object arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x000669B8 File Offset: 0x00064BB8
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00005BCF File Offset: 0x00003DCF
		public unsafe Object arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x000669E8 File Offset: 0x00064BE8
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x00005BEE File Offset: 0x00003DEE
		public unsafe Object arg2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x00066A18 File Offset: 0x00064C18
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x00005C0D File Offset: 0x00003E0D
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeFieldInfoPtr_oneArgArray;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr_twoArgArray;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeFieldInfoPtr_threeArgArray;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeFieldInfoPtr_arg0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeFieldInfoPtr_arg1;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeFieldInfoPtr_arg2;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_Object_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_GetAtSlow_Private_Object_Int32_0;
	}
}
