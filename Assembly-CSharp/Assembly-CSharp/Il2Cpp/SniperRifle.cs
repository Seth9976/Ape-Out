using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000197 RID: 407
	public class SniperRifle : GuardGun
	{
		// Token: 0x06002FC1 RID: 12225 RVA: 0x000B7CAC File Offset: 0x000B5EAC
		// Note: this type is marked as 'beforefieldinit'.
		static SniperRifle()
		{
			Il2CppClassPointerStore<SniperRifle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SniperRifle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SniperRifle>.NativeClassPtr);
			SniperRifle.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SniperRifle>.NativeClassPtr, "line");
			SniperRifle.NativeFieldInfoPtr_ray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SniperRifle>.NativeClassPtr, "ray");
			SniperRifle.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SniperRifle>.NativeClassPtr, 100667020);
			SniperRifle.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SniperRifle>.NativeClassPtr, 100667021);
			SniperRifle.NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SniperRifle>.NativeClassPtr, 100667022);
			SniperRifle.NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SniperRifle>.NativeClassPtr, 100667023);
			SniperRifle.NativeMethodInfoPtr_Laser_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SniperRifle>.NativeClassPtr, 100667024);
			SniperRifle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SniperRifle>.NativeClassPtr, 100667025);
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x000B7D7C File Offset: 0x000B5F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83489, XrefRangeEnd = 83493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SniperRifle.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x000B7DB8 File Offset: 0x000B5FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83493, XrefRangeEnd = 83494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SniperRifle.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x000B7DEC File Offset: 0x000B5FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83494, XrefRangeEnd = 83646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MakeBulletGo(Vector2 shotVect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shotVect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SniperRifle.NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x000B7E38 File Offset: 0x000B6038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83646, XrefRangeEnd = 83656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayShotSnd(Vector3 muzzlePosition, Quaternion aimRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref muzzlePosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aimRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SniperRifle.NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_Void_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x000B7E90 File Offset: 0x000B6090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83784, RefRangeEnd = 83785, XrefRangeStart = 83656, XrefRangeEnd = 83784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Laser()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SniperRifle.NativeMethodInfoPtr_Laser_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x000B7EC4 File Offset: 0x000B60C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SniperRifle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SniperRifle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SniperRifle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00020F3C File Offset: 0x0001F13C
		public SniperRifle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x000B7F00 File Offset: 0x000B6100
		// (set) Token: 0x06002FCA RID: 12234 RVA: 0x00020F45 File Offset: 0x0001F145
		public unsafe LineRenderer line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SniperRifle.NativeFieldInfoPtr_line);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SniperRifle.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06002FCB RID: 12235 RVA: 0x000B7F30 File Offset: 0x000B6130
		// (set) Token: 0x06002FCC RID: 12236 RVA: 0x00020F64 File Offset: 0x0001F164
		public unsafe RaycastHit2D ray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SniperRifle.NativeFieldInfoPtr_ray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SniperRifle.NativeFieldInfoPtr_ray)) = value;
			}
		}

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeFieldInfoPtr_ray;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeMethodInfoPtr_MakeBulletGo_Public_Virtual_Void_Vector2_0;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeMethodInfoPtr_PlayShotSnd_Public_Virtual_Void_Vector3_Quaternion_0;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeMethodInfoPtr_Laser_Public_Void_0;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
