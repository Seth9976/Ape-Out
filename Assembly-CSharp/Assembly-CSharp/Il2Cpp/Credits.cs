using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000B2 RID: 178
	public class Credits : MonoBehaviour
	{
		// Token: 0x060015B1 RID: 5553 RVA: 0x000718F4 File Offset: 0x0006FAF4
		// Note: this type is marked as 'beforefieldinit'.
		static Credits()
		{
			Il2CppClassPointerStore<Credits>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Credits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Credits>.NativeClassPtr);
			Credits.NativeFieldInfoPtr_credits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "credits");
			Credits.NativeFieldInfoPtr_dumbCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "dumbCard");
			Credits.NativeFieldInfoPtr_sprayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "sprayers");
			Credits.NativeFieldInfoPtr_txtCols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "txtCols");
			Credits.NativeFieldInfoPtr_palTexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "palTexes");
			Credits.NativeFieldInfoPtr_waitTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "waitTimes");
			Credits.NativeFieldInfoPtr_gapTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "gapTimes");
			Credits.NativeFieldInfoPtr_palCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "palCam");
			Credits.NativeFieldInfoPtr_newRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "newRend");
			Credits.NativeFieldInfoPtr_oldRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "oldRend");
			Credits.NativeFieldInfoPtr_palQuadMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "palQuadMat");
			Credits.NativeFieldInfoPtr_skipFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "skipFlag");
			Credits.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "index");
			Credits.NativeFieldInfoPtr_song = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "song");
			Credits.NativeFieldInfoPtr_endedIt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "endedIt");
			Credits.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits>.NativeClassPtr, "me");
			Credits.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits>.NativeClassPtr, 100665108);
			Credits.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits>.NativeClassPtr, 100665109);
			Credits.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits>.NativeClassPtr, 100665110);
			Credits.NativeMethodInfoPtr_PressedAButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits>.NativeClassPtr, 100665111);
			Credits.NativeMethodInfoPtr_ShowAllTheCredits_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits>.NativeClassPtr, 100665112);
			Credits.NativeMethodInfoPtr_DestroyInABit_Private_IEnumerator_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits>.NativeClassPtr, 100665113);
			Credits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits>.NativeClassPtr, 100665114);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00071AF0 File Offset: 0x0006FCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54526, XrefRangeEnd = 54534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00071B24 File Offset: 0x0006FD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54534, XrefRangeEnd = 54542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00071B58 File Offset: 0x0006FD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54542, XrefRangeEnd = 54556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00071B8C File Offset: 0x0006FD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54556, XrefRangeEnd = 54570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PressedAButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits.NativeMethodInfoPtr_PressedAButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00071BC8 File Offset: 0x0006FDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54570, XrefRangeEnd = 54573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowAllTheCredits()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits.NativeMethodInfoPtr_ShowAllTheCredits_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00071C08 File Offset: 0x0006FE08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54576, RefRangeEnd = 54577, XrefRangeStart = 54573, XrefRangeEnd = 54576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DestroyInABit(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits.NativeMethodInfoPtr_DestroyInABit_Private_IEnumerator_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00071C58 File Offset: 0x0006FE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Credits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Credits>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0000FB9A File Offset: 0x0000DD9A
		public Credits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00071C94 File Offset: 0x0006FE94
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x0000FBA3 File Offset: 0x0000DDA3
		public unsafe Il2CppReferenceArray<GameObject> credits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_credits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_credits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x00071CC4 File Offset: 0x0006FEC4
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x0000FBC2 File Offset: 0x0000DDC2
		public unsafe GameObject dumbCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_dumbCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_dumbCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x00071CF4 File Offset: 0x0006FEF4
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x0000FBE1 File Offset: 0x0000DDE1
		public unsafe Il2CppReferenceArray<GameObject> sprayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_sprayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_sprayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x00071D24 File Offset: 0x0006FF24
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x0000FC00 File Offset: 0x0000DE00
		public unsafe Il2CppStructArray<Color> txtCols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_txtCols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_txtCols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00071D54 File Offset: 0x0006FF54
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x0000FC1F File Offset: 0x0000DE1F
		public unsafe Il2CppReferenceArray<Texture> palTexes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_palTexes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_palTexes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00071D84 File Offset: 0x0006FF84
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x0000FC3E File Offset: 0x0000DE3E
		public unsafe Il2CppStructArray<float> waitTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_waitTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_waitTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x00071DB4 File Offset: 0x0006FFB4
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x0000FC5D File Offset: 0x0000DE5D
		public unsafe Il2CppStructArray<float> gapTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_gapTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_gapTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x00071DE4 File Offset: 0x0006FFE4
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x0000FC7C File Offset: 0x0000DE7C
		public unsafe Camera palCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_palCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_palCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x00071E14 File Offset: 0x00070014
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x0000FC9B File Offset: 0x0000DE9B
		public unsafe RenderTexture newRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_newRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_newRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00071E44 File Offset: 0x00070044
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x0000FCBA File Offset: 0x0000DEBA
		public unsafe RenderTexture oldRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_oldRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_oldRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x00071E74 File Offset: 0x00070074
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x0000FCD9 File Offset: 0x0000DED9
		public unsafe Material palQuadMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_palQuadMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_palQuadMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x00071EA4 File Offset: 0x000700A4
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x0000FCF8 File Offset: 0x0000DEF8
		public unsafe bool skipFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_skipFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_skipFlag)) = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x00071ECC File Offset: 0x000700CC
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x0000FD13 File Offset: 0x0000DF13
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x00071EF4 File Offset: 0x000700F4
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x0000FD2E File Offset: 0x0000DF2E
		public unsafe AudioSource song
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_song);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_song), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x00071F24 File Offset: 0x00070124
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0000FD4D File Offset: 0x0000DF4D
		public unsafe bool endedIt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_endedIt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits.NativeFieldInfoPtr_endedIt)) = value;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00071F4C File Offset: 0x0007014C
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0000FD68 File Offset: 0x0000DF68
		public unsafe static Credits me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Credits.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Credits>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Credits.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeFieldInfoPtr_credits;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeFieldInfoPtr_dumbCard;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeFieldInfoPtr_sprayers;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeFieldInfoPtr_txtCols;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeFieldInfoPtr_palTexes;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeFieldInfoPtr_waitTimes;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeFieldInfoPtr_gapTimes;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeFieldInfoPtr_palCam;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeFieldInfoPtr_newRend;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeFieldInfoPtr_oldRend;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeFieldInfoPtr_palQuadMat;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeFieldInfoPtr_skipFlag;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeFieldInfoPtr_song;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeFieldInfoPtr_endedIt;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_PressedAButton_Public_Boolean_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_ShowAllTheCredits_Private_IEnumerator_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_DestroyInABit_Private_IEnumerator_GameObject_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002F1 RID: 753
		[ObfuscatedName("Credits+<ShowAllTheCredits>d__20")]
		public sealed class _ShowAllTheCredits_d__20 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E9E RID: 20126 RVA: 0x00120184 File Offset: 0x0011E384
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowAllTheCredits_d__20()
			{
				Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Credits>.NativeClassPtr, "<ShowAllTheCredits>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr);
				Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, "<>1__state");
				Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, "<>2__current");
				Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, "<>4__this");
				Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__j_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, "<j>5__2");
				Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__sort_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, "<sort>5__3");
				Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, "<i>5__4");
				Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__boop_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, "<boop>5__5");
				Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__lastIndex_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, "<lastIndex>5__6");
				Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__timtim_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, "<timtim>5__7");
				Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, 100665115);
				Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, 100665116);
				Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, 100665117);
				Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, 100665118);
				Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, 100665119);
				Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr, 100665120);
			}

			// Token: 0x06004E9F RID: 20127 RVA: 0x001202DC File Offset: 0x0011E4DC
			[CallerCount(0)]
			public unsafe _ShowAllTheCredits_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Credits._ShowAllTheCredits_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EA0 RID: 20128 RVA: 0x00120324 File Offset: 0x0011E524
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EA1 RID: 20129 RVA: 0x00120358 File Offset: 0x0011E558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54440, XrefRangeEnd = 54512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CAE RID: 7342
			// (get) Token: 0x06004EA2 RID: 20130 RVA: 0x00120394 File Offset: 0x0011E594
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EA3 RID: 20131 RVA: 0x001203D4 File Offset: 0x0011E5D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54512, XrefRangeEnd = 54517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CAF RID: 7343
			// (get) Token: 0x06004EA4 RID: 20132 RVA: 0x00120408 File Offset: 0x0011E608
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._ShowAllTheCredits_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EA5 RID: 20133 RVA: 0x0002E129 File Offset: 0x0002C329
			public _ShowAllTheCredits_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CA5 RID: 7333
			// (get) Token: 0x06004EA6 RID: 20134 RVA: 0x00120448 File Offset: 0x0011E648
			// (set) Token: 0x06004EA7 RID: 20135 RVA: 0x0002E132 File Offset: 0x0002C332
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CA6 RID: 7334
			// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x00120470 File Offset: 0x0011E670
			// (set) Token: 0x06004EA9 RID: 20137 RVA: 0x0002E14D File Offset: 0x0002C34D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CA7 RID: 7335
			// (get) Token: 0x06004EAA RID: 20138 RVA: 0x001204A0 File Offset: 0x0011E6A0
			// (set) Token: 0x06004EAB RID: 20139 RVA: 0x0002E16C File Offset: 0x0002C36C
			public unsafe Credits __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Credits>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CA8 RID: 7336
			// (get) Token: 0x06004EAC RID: 20140 RVA: 0x001204D0 File Offset: 0x0011E6D0
			// (set) Token: 0x06004EAD RID: 20141 RVA: 0x0002E18B File Offset: 0x0002C38B
			public unsafe int _j_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__j_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__j_5__2)) = value;
				}
			}

			// Token: 0x17001CA9 RID: 7337
			// (get) Token: 0x06004EAE RID: 20142 RVA: 0x001204F8 File Offset: 0x0011E6F8
			// (set) Token: 0x06004EAF RID: 20143 RVA: 0x0002E1A6 File Offset: 0x0002C3A6
			public unsafe int _sort_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__sort_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__sort_5__3)) = value;
				}
			}

			// Token: 0x17001CAA RID: 7338
			// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x00120520 File Offset: 0x0011E720
			// (set) Token: 0x06004EB1 RID: 20145 RVA: 0x0002E1C1 File Offset: 0x0002C3C1
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x17001CAB RID: 7339
			// (get) Token: 0x06004EB2 RID: 20146 RVA: 0x00120548 File Offset: 0x0011E748
			// (set) Token: 0x06004EB3 RID: 20147 RVA: 0x0002E1DC File Offset: 0x0002C3DC
			public unsafe GameObject _boop_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__boop_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__boop_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CAC RID: 7340
			// (get) Token: 0x06004EB4 RID: 20148 RVA: 0x00120578 File Offset: 0x0011E778
			// (set) Token: 0x06004EB5 RID: 20149 RVA: 0x0002E1FB File Offset: 0x0002C3FB
			public unsafe int _lastIndex_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__lastIndex_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__lastIndex_5__6)) = value;
				}
			}

			// Token: 0x17001CAD RID: 7341
			// (get) Token: 0x06004EB6 RID: 20150 RVA: 0x001205A0 File Offset: 0x0011E7A0
			// (set) Token: 0x06004EB7 RID: 20151 RVA: 0x0002E216 File Offset: 0x0002C416
			public unsafe float _timtim_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__timtim_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._ShowAllTheCredits_d__20.NativeFieldInfoPtr__timtim_5__7)) = value;
				}
			}

			// Token: 0x04003376 RID: 13174
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003377 RID: 13175
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003378 RID: 13176
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003379 RID: 13177
			private static readonly IntPtr NativeFieldInfoPtr__j_5__2;

			// Token: 0x0400337A RID: 13178
			private static readonly IntPtr NativeFieldInfoPtr__sort_5__3;

			// Token: 0x0400337B RID: 13179
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400337C RID: 13180
			private static readonly IntPtr NativeFieldInfoPtr__boop_5__5;

			// Token: 0x0400337D RID: 13181
			private static readonly IntPtr NativeFieldInfoPtr__lastIndex_5__6;

			// Token: 0x0400337E RID: 13182
			private static readonly IntPtr NativeFieldInfoPtr__timtim_5__7;

			// Token: 0x0400337F RID: 13183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003380 RID: 13184
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003381 RID: 13185
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003382 RID: 13186
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003383 RID: 13187
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003384 RID: 13188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002F2 RID: 754
		[ObfuscatedName("Credits+<DestroyInABit>d__21")]
		public sealed class _DestroyInABit_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x06004EB8 RID: 20152 RVA: 0x001205C8 File Offset: 0x0011E7C8
			// Note: this type is marked as 'beforefieldinit'.
			static _DestroyInABit_d__21()
			{
				Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Credits>.NativeClassPtr, "<DestroyInABit>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr);
				Credits._DestroyInABit_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr, "<>1__state");
				Credits._DestroyInABit_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr, "<>2__current");
				Credits._DestroyInABit_d__21.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr, "obj");
				Credits._DestroyInABit_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr, 100665121);
				Credits._DestroyInABit_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr, 100665122);
				Credits._DestroyInABit_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr, 100665123);
				Credits._DestroyInABit_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr, 100665124);
				Credits._DestroyInABit_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr, 100665125);
				Credits._DestroyInABit_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr, 100665126);
			}

			// Token: 0x06004EB9 RID: 20153 RVA: 0x001206A8 File Offset: 0x0011E8A8
			[CallerCount(0)]
			public unsafe _DestroyInABit_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Credits._DestroyInABit_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._DestroyInABit_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EBA RID: 20154 RVA: 0x001206F0 File Offset: 0x0011E8F0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._DestroyInABit_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EBB RID: 20155 RVA: 0x00120724 File Offset: 0x0011E924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54517, XrefRangeEnd = 54521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._DestroyInABit_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CB3 RID: 7347
			// (get) Token: 0x06004EBC RID: 20156 RVA: 0x00120760 File Offset: 0x0011E960
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._DestroyInABit_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EBD RID: 20157 RVA: 0x001207A0 File Offset: 0x0011E9A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54521, XrefRangeEnd = 54526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._DestroyInABit_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CB4 RID: 7348
			// (get) Token: 0x06004EBE RID: 20158 RVA: 0x001207D4 File Offset: 0x0011E9D4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Credits._DestroyInABit_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EBF RID: 20159 RVA: 0x0002E231 File Offset: 0x0002C431
			public _DestroyInABit_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CB0 RID: 7344
			// (get) Token: 0x06004EC0 RID: 20160 RVA: 0x00120814 File Offset: 0x0011EA14
			// (set) Token: 0x06004EC1 RID: 20161 RVA: 0x0002E23A File Offset: 0x0002C43A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._DestroyInABit_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._DestroyInABit_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CB1 RID: 7345
			// (get) Token: 0x06004EC2 RID: 20162 RVA: 0x0012083C File Offset: 0x0011EA3C
			// (set) Token: 0x06004EC3 RID: 20163 RVA: 0x0002E255 File Offset: 0x0002C455
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._DestroyInABit_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._DestroyInABit_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB2 RID: 7346
			// (get) Token: 0x06004EC4 RID: 20164 RVA: 0x0012086C File Offset: 0x0011EA6C
			// (set) Token: 0x06004EC5 RID: 20165 RVA: 0x0002E274 File Offset: 0x0002C474
			public unsafe GameObject obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._DestroyInABit_d__21.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Credits._DestroyInABit_d__21.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003385 RID: 13189
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003386 RID: 13190
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003387 RID: 13191
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x04003388 RID: 13192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003389 RID: 13193
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400338A RID: 13194
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400338B RID: 13195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400338C RID: 13196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400338D RID: 13197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
