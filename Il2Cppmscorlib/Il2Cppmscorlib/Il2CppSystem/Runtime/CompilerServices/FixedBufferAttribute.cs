using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000430 RID: 1072
	public sealed class FixedBufferAttribute : Attribute
	{
		// Token: 0x0600434B RID: 17227 RVA: 0x00137CD4 File Offset: 0x00135ED4
		// Note: this type is marked as 'beforefieldinit'.
		static FixedBufferAttribute()
		{
			Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "FixedBufferAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr);
			FixedBufferAttribute.NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, "elementType");
			FixedBufferAttribute.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, "length");
			FixedBufferAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, 100673135);
			FixedBufferAttribute.NativeMethodInfoPtr_get_ElementType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, 100673136);
			FixedBufferAttribute.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr, 100673137);
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00137D68 File Offset: 0x00135F68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 22674, RefRangeEnd = 22677, XrefRangeStart = 22674, XrefRangeEnd = 22677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixedBufferAttribute(Type elementType, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixedBufferAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x00137DC4 File Offset: 0x00135FC4
		public unsafe Type ElementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferAttribute.NativeMethodInfoPtr_get_ElementType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x00137E04 File Offset: 0x00136004
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixedBufferAttribute.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x000197FE File Offset: 0x000179FE
		public FixedBufferAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x00137E40 File Offset: 0x00136040
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x00019807 File Offset: 0x00017A07
		public unsafe Type elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr_elementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr_elementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x00137E70 File Offset: 0x00136070
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x00019826 File Offset: 0x00017A26
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixedBufferAttribute.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x040036B5 RID: 14005
		private static readonly IntPtr NativeFieldInfoPtr_elementType;

		// Token: 0x040036B6 RID: 14006
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x040036B7 RID: 14007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Int32_0;

		// Token: 0x040036B8 RID: 14008
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementType_Public_get_Type_0;

		// Token: 0x040036B9 RID: 14009
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
	}
}
