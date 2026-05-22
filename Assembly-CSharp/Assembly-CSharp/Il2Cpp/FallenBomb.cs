using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000CC RID: 204
	public class FallenBomb : StaticBreakable
	{
		// Token: 0x0600185E RID: 6238 RVA: 0x00078C58 File Offset: 0x00076E58
		// Note: this type is marked as 'beforefieldinit'.
		static FallenBomb()
		{
			Il2CppClassPointerStore<FallenBomb>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FallenBomb");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr);
			FallenBomb.NativeFieldInfoPtr_offSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr, "offSet");
			FallenBomb.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr, "timer");
			FallenBomb.NativeFieldInfoPtr_blowTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr, "blowTime");
			FallenBomb.NativeFieldInfoPtr_invTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr, "invTime");
			FallenBomb.NativeFieldInfoPtr_dad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr, "dad");
			FallenBomb.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr, 100665293);
			FallenBomb.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr, 100665294);
			FallenBomb.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr, 100665295);
			FallenBomb.NativeMethodInfoPtr_Break_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr, 100665296);
			FallenBomb.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr, 100665297);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00078D50 File Offset: 0x00076F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57576, XrefRangeEnd = 57593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallenBomb.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00078D84 File Offset: 0x00076F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57593, XrefRangeEnd = 57595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallenBomb.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00078DB8 File Offset: 0x00076FB8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FallenBomb.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00078DF4 File Offset: 0x00076FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57595, XrefRangeEnd = 57613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FallenBomb.NativeMethodInfoPtr_Break_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00078E30 File Offset: 0x00077030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57613, XrefRangeEnd = 57614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FallenBomb()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallenBomb>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallenBomb.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00011850 File Offset: 0x0000FA50
		public FallenBomb(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00078E6C File Offset: 0x0007706C
		// (set) Token: 0x06001866 RID: 6246 RVA: 0x00011859 File Offset: 0x0000FA59
		public unsafe Vector3 offSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenBomb.NativeFieldInfoPtr_offSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenBomb.NativeFieldInfoPtr_offSet)) = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00078E94 File Offset: 0x00077094
		// (set) Token: 0x06001868 RID: 6248 RVA: 0x00011874 File Offset: 0x0000FA74
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenBomb.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenBomb.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x00078EBC File Offset: 0x000770BC
		// (set) Token: 0x0600186A RID: 6250 RVA: 0x0001188F File Offset: 0x0000FA8F
		public unsafe float blowTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenBomb.NativeFieldInfoPtr_blowTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenBomb.NativeFieldInfoPtr_blowTime)) = value;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x00078EE4 File Offset: 0x000770E4
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x000118AA File Offset: 0x0000FAAA
		public unsafe float invTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenBomb.NativeFieldInfoPtr_invTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenBomb.NativeFieldInfoPtr_invTime)) = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x00078F0C File Offset: 0x0007710C
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x000118C5 File Offset: 0x0000FAC5
		public unsafe BombingManager dad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenBomb.NativeFieldInfoPtr_dad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BombingManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallenBomb.NativeFieldInfoPtr_dad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeFieldInfoPtr_offSet;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeFieldInfoPtr_blowTime;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeFieldInfoPtr_invTime;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr_dad;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
