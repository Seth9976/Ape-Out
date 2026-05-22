using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp
{
	// Token: 0x02000154 RID: 340
	public class Intv2Comp : EqualityComparer<Intv2>
	{
		// Token: 0x06002926 RID: 10534 RVA: 0x000A60F4 File Offset: 0x000A42F4
		// Note: this type is marked as 'beforefieldinit'.
		static Intv2Comp()
		{
			Il2CppClassPointerStore<Intv2Comp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Intv2Comp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intv2Comp>.NativeClassPtr);
			Intv2Comp.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Intv2_Intv2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intv2Comp>.NativeClassPtr, 100666556);
			Intv2Comp.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Intv2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intv2Comp>.NativeClassPtr, 100666557);
			Intv2Comp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intv2Comp>.NativeClassPtr, 100666558);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000A6160 File Offset: 0x000A4360
		[CallerCount(0)]
		public unsafe override bool Equals(Intv2 a, Intv2 b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Intv2Comp.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Intv2_Intv2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000A61C4 File Offset: 0x000A43C4
		[CallerCount(0)]
		public unsafe override int GetHashCode(Intv2 a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Intv2Comp.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Intv2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000A6218 File Offset: 0x000A4418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76852, XrefRangeEnd = 76853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intv2Comp()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intv2Comp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intv2Comp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x0001CB09 File Offset: 0x0001AD09
		public Intv2Comp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Intv2_Intv2_0;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Intv2_0;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
