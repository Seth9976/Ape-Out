using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000054 RID: 84
	public class SECTR_AudioDemoUI : SECTR_DemoUI
	{
		// Token: 0x06000C40 RID: 3136 RVA: 0x0005905C File Offset: 0x0005725C
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_AudioDemoUI()
		{
			Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_AudioDemoUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr);
			SECTR_AudioDemoUI.NativeFieldInfoPtr_chatterInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, "chatterInstance");
			SECTR_AudioDemoUI.NativeFieldInfoPtr_SoftCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, "SoftCue");
			SECTR_AudioDemoUI.NativeFieldInfoPtr_ChatterCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, "ChatterCue");
			SECTR_AudioDemoUI.NativeFieldInfoPtr_GunshotCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, "GunshotCue");
			SECTR_AudioDemoUI.NativeFieldInfoPtr_ExplosionCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, "ExplosionCue");
			SECTR_AudioDemoUI.NativeFieldInfoPtr_AudioPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, "AudioPrefab");
			SECTR_AudioDemoUI.NativeFieldInfoPtr_PrefabThrowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, "PrefabThrowSpeed");
			SECTR_AudioDemoUI.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, 100664374);
			SECTR_AudioDemoUI.NativeMethodInfoPtr_ShowHUD_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, 100664375);
			SECTR_AudioDemoUI.NativeMethodInfoPtr_PlaySoft_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, 100664376);
			SECTR_AudioDemoUI.NativeMethodInfoPtr_PlayChatter_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, 100664377);
			SECTR_AudioDemoUI.NativeMethodInfoPtr_PlayGunshot_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, 100664378);
			SECTR_AudioDemoUI.NativeMethodInfoPtr_PlayExplosion_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, 100664379);
			SECTR_AudioDemoUI.NativeMethodInfoPtr_ThrowPrefab_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, 100664380);
			SECTR_AudioDemoUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr, 100664381);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x000591B8 File Offset: 0x000573B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42421, XrefRangeEnd = 42535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_AudioDemoUI.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000591F4 File Offset: 0x000573F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42535, XrefRangeEnd = 42539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHUD(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioDemoUI.NativeMethodInfoPtr_ShowHUD_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00059234 File Offset: 0x00057434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42539, XrefRangeEnd = 42551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaySoft(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioDemoUI.NativeMethodInfoPtr_PlaySoft_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00059274 File Offset: 0x00057474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42551, XrefRangeEnd = 42568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayChatter(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioDemoUI.NativeMethodInfoPtr_PlayChatter_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000592B4 File Offset: 0x000574B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42568, XrefRangeEnd = 42580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayGunshot(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioDemoUI.NativeMethodInfoPtr_PlayGunshot_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000592F4 File Offset: 0x000574F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42580, XrefRangeEnd = 42592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayExplosion(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioDemoUI.NativeMethodInfoPtr_PlayExplosion_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00059334 File Offset: 0x00057534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42592, XrefRangeEnd = 42619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowPrefab(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioDemoUI.NativeMethodInfoPtr_ThrowPrefab_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00059374 File Offset: 0x00057574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42619, XrefRangeEnd = 42630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioDemoUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioDemoUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioDemoUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000096E7 File Offset: 0x000078E7
		public SECTR_AudioDemoUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x000593B0 File Offset: 0x000575B0
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x000096F0 File Offset: 0x000078F0
		public SECTR_AudioCueInstance chatterInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_chatterInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_chatterInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x000593E0 File Offset: 0x000575E0
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x0000971E File Offset: 0x0000791E
		public unsafe SECTR_AudioCue SoftCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_SoftCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_SoftCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00059410 File Offset: 0x00057610
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x0000973D File Offset: 0x0000793D
		public unsafe SECTR_AudioCue ChatterCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_ChatterCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_ChatterCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x00059440 File Offset: 0x00057640
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x0000975C File Offset: 0x0000795C
		public unsafe SECTR_AudioCue GunshotCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_GunshotCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_GunshotCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00059470 File Offset: 0x00057670
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x0000977B File Offset: 0x0000797B
		public unsafe SECTR_AudioCue ExplosionCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_ExplosionCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_ExplosionCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x000594A0 File Offset: 0x000576A0
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x0000979A File Offset: 0x0000799A
		public unsafe GameObject AudioPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_AudioPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_AudioPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x000594D0 File Offset: 0x000576D0
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x000097B9 File Offset: 0x000079B9
		public unsafe float PrefabThrowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_PrefabThrowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioDemoUI.NativeFieldInfoPtr_PrefabThrowSpeed)) = value;
			}
		}

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeFieldInfoPtr_chatterInstance;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr_SoftCue;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeFieldInfoPtr_ChatterCue;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr_GunshotCue;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionCue;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_AudioPrefab;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_PrefabThrowSpeed;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_ShowHUD_Protected_Void_Boolean_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_PlaySoft_Protected_Void_Boolean_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_PlayChatter_Protected_Void_Boolean_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_PlayGunshot_Protected_Void_Boolean_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_PlayExplosion_Protected_Void_Boolean_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_ThrowPrefab_Protected_Void_Boolean_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
