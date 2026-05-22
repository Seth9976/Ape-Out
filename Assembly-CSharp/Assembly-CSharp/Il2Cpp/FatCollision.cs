using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000CF RID: 207
	public class FatCollision : GuardCollision
	{
		// Token: 0x060018A7 RID: 6311 RVA: 0x00079838 File Offset: 0x00077A38
		// Note: this type is marked as 'beforefieldinit'.
		static FatCollision()
		{
			Il2CppClassPointerStore<FatCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FatCollision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FatCollision>.NativeClassPtr);
			FatCollision.NativeMethodInfoPtr_HitDude_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatCollision>.NativeClassPtr, 100665322);
			FatCollision.NativeMethodInfoPtr_HitWall_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatCollision>.NativeClassPtr, 100665323);
			FatCollision.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FatCollision>.NativeClassPtr, 100665324);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000798A4 File Offset: 0x00077AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58059, XrefRangeEnd = 58091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HitDude(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FatCollision.NativeMethodInfoPtr_HitDude_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000798F4 File Offset: 0x00077AF4
		[CallerCount(0)]
		public unsafe override void HitWall(Vector2 pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FatCollision.NativeMethodInfoPtr_HitWall_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00079940 File Offset: 0x00077B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FatCollision()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FatCollision>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FatCollision.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00011B26 File Offset: 0x0000FD26
		public FatCollision(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_HitDude_Public_Virtual_Void_GameObject_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_HitWall_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
