using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001CB RID: 459
	public class TranqGun : GuardGun
	{
		// Token: 0x06003269 RID: 12905 RVA: 0x000BEB70 File Offset: 0x000BCD70
		// Note: this type is marked as 'beforefieldinit'.
		static TranqGun()
		{
			Il2CppClassPointerStore<TranqGun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TranqGun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranqGun>.NativeClassPtr);
			TranqGun.NativeFieldInfoPtr_tranqPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranqGun>.NativeClassPtr, "tranqPrefab");
			TranqGun.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqGun>.NativeClassPtr, 100667216);
			TranqGun.NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqGun>.NativeClassPtr, 100667217);
			TranqGun.NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqGun>.NativeClassPtr, 100667218);
			TranqGun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqGun>.NativeClassPtr, 100667219);
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x000BEC04 File Offset: 0x000BCE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85760, XrefRangeEnd = 85761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranqGun.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x000BEC40 File Offset: 0x000BCE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85761, XrefRangeEnd = 85784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MakeBulletGo(Vector2 shotVect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shotVect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranqGun.NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x000BEC8C File Offset: 0x000BCE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85784, XrefRangeEnd = 85794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayShotSnd(Vector3 muzzlePosition, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref muzzlePosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TranqGun.NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x000BECE4 File Offset: 0x000BCEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TranqGun()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranqGun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqGun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x00022969 File Offset: 0x00020B69
		public TranqGun(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x000BED20 File Offset: 0x000BCF20
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x00022972 File Offset: 0x00020B72
		public unsafe GameObject tranqPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqGun.NativeFieldInfoPtr_tranqPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqGun.NativeFieldInfoPtr_tranqPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeFieldInfoPtr_tranqPrefab;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_Void_Vector3_Quaternion_0;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
