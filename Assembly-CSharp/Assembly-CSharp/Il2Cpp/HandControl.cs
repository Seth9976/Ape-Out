using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000108 RID: 264
	public class HandControl : MonoBehaviour
	{
		// Token: 0x06001F33 RID: 7987 RVA: 0x0008BF38 File Offset: 0x0008A138
		// Note: this type is marked as 'beforefieldinit'.
		static HandControl()
		{
			Il2CppClassPointerStore<HandControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HandControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandControl>.NativeClassPtr);
			HandControl.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "state");
			HandControl.NativeFieldInfoPtr_pHands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "pHands");
			HandControl.NativeFieldInfoPtr_handNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "handNum");
			HandControl.NativeFieldInfoPtr_wallHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "wallHand");
			HandControl.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "player");
			HandControl.NativeFieldInfoPtr_handRad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "handRad");
			HandControl.NativeFieldInfoPtr_sLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "sLocalPos");
			HandControl.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "sprite");
			HandControl.NativeFieldInfoPtr_openSpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "openSpr");
			HandControl.NativeFieldInfoPtr_fistSpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "fistSpr");
			HandControl.NativeFieldInfoPtr_grabSpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "grabSpr");
			HandControl.NativeFieldInfoPtr_throwSpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "throwSpr");
			HandControl.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "hits");
			HandControl.NativeFieldInfoPtr_filt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "filt");
			HandControl.NativeFieldInfoPtr_ignoreRaycast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "ignoreRaycast");
			HandControl.NativeFieldInfoPtr_handLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "handLayer");
			HandControl.NativeFieldInfoPtr_wallLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandControl>.NativeClassPtr, "wallLayer");
			HandControl.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandControl>.NativeClassPtr, 100665790);
			HandControl.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandControl>.NativeClassPtr, 100665791);
			HandControl.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandControl>.NativeClassPtr, 100665792);
			HandControl.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandControl>.NativeClassPtr, 100665793);
			HandControl.NativeMethodInfoPtr_BloodStepped_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandControl>.NativeClassPtr, 100665794);
			HandControl.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandControl>.NativeClassPtr, 100665795);
			HandControl.NativeMethodInfoPtr_OnCollisionStay2D_Public_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandControl>.NativeClassPtr, 100665796);
			HandControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandControl>.NativeClassPtr, 100665797);
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x0008C15C File Offset: 0x0008A35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66224, XrefRangeEnd = 66239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandControl.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x0008C190 File Offset: 0x0008A390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66239, XrefRangeEnd = 66248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandControl.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x0008C1C4 File Offset: 0x0008A3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66248, XrefRangeEnd = 66308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandControl.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0008C1F8 File Offset: 0x0008A3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66308, XrefRangeEnd = 66354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandControl.NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0008C22C File Offset: 0x0008A42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66354, XrefRangeEnd = 66362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BloodStepped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandControl.NativeMethodInfoPtr_BloodStepped_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x0008C260 File Offset: 0x0008A460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66362, XrefRangeEnd = 66399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter2D(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandControl.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x0008C2A4 File Offset: 0x0008A4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66399, XrefRangeEnd = 66416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionStay2D(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandControl.NativeMethodInfoPtr_OnCollisionStay2D_Public_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0008C2E8 File Offset: 0x0008A4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00015D01 File Offset: 0x00013F01
		public HandControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x0008C324 File Offset: 0x0008A524
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x00015D0A File Offset: 0x00013F0A
		public unsafe PlayerState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x0008C354 File Offset: 0x0008A554
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x00015D29 File Offset: 0x00013F29
		public unsafe PlayerHands pHands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_pHands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerHands>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_pHands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x0008C384 File Offset: 0x0008A584
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x00015D48 File Offset: 0x00013F48
		public unsafe int handNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_handNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_handNum)) = value;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x0008C3AC File Offset: 0x0008A5AC
		// (set) Token: 0x06001F44 RID: 8004 RVA: 0x00015D63 File Offset: 0x00013F63
		public unsafe GameObject wallHand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_wallHand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_wallHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0008C3DC File Offset: 0x0008A5DC
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x00015D82 File Offset: 0x00013F82
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x0008C40C File Offset: 0x0008A60C
		// (set) Token: 0x06001F48 RID: 8008 RVA: 0x00015DA1 File Offset: 0x00013FA1
		public unsafe float handRad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_handRad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_handRad)) = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x0008C434 File Offset: 0x0008A634
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x00015DBC File Offset: 0x00013FBC
		public unsafe Vector2 sLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_sLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_sLocalPos)) = value;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x0008C45C File Offset: 0x0008A65C
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00015DD7 File Offset: 0x00013FD7
		public unsafe SpriteRenderer sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x0008C48C File Offset: 0x0008A68C
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00015DF6 File Offset: 0x00013FF6
		public unsafe Sprite openSpr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_openSpr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_openSpr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x0008C4BC File Offset: 0x0008A6BC
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x00015E15 File Offset: 0x00014015
		public unsafe Sprite fistSpr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_fistSpr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_fistSpr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x0008C4EC File Offset: 0x0008A6EC
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x00015E34 File Offset: 0x00014034
		public unsafe Sprite grabSpr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_grabSpr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_grabSpr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x0008C51C File Offset: 0x0008A71C
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x00015E53 File Offset: 0x00014053
		public unsafe Sprite throwSpr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_throwSpr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_throwSpr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x0008C54C File Offset: 0x0008A74C
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x00015E72 File Offset: 0x00014072
		public unsafe Il2CppStructArray<RaycastHit2D> hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x0008C57C File Offset: 0x0008A77C
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00015E91 File Offset: 0x00014091
		public unsafe ContactFilter2D filt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_filt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_filt)) = value;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x0008C5A4 File Offset: 0x0008A7A4
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x00015EAC File Offset: 0x000140AC
		public unsafe int ignoreRaycast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_ignoreRaycast);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_ignoreRaycast)) = value;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x0008C5CC File Offset: 0x0008A7CC
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x00015EC7 File Offset: 0x000140C7
		public unsafe int handLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_handLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_handLayer)) = value;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x0008C5F4 File Offset: 0x0008A7F4
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x00015EE2 File Offset: 0x000140E2
		public unsafe int wallLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_wallLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandControl.NativeFieldInfoPtr_wallLayer)) = value;
			}
		}

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeFieldInfoPtr_pHands;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeFieldInfoPtr_handNum;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeFieldInfoPtr_wallHand;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeFieldInfoPtr_handRad;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeFieldInfoPtr_sLocalPos;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeFieldInfoPtr_openSpr;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeFieldInfoPtr_fistSpr;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeFieldInfoPtr_grabSpr;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeFieldInfoPtr_throwSpr;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeFieldInfoPtr_hits;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeFieldInfoPtr_filt;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeFieldInfoPtr_ignoreRaycast;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeFieldInfoPtr_handLayer;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeFieldInfoPtr_wallLayer;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Void_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_BloodStepped_Public_Void_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionStay2D_Public_Void_Collision2D_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
