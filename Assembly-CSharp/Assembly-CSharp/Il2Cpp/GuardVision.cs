using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000106 RID: 262
	public class GuardVision : MonoBehaviour
	{
		// Token: 0x06001EF6 RID: 7926 RVA: 0x0008B558 File Offset: 0x00089758
		// Note: this type is marked as 'beforefieldinit'.
		static GuardVision()
		{
			Il2CppClassPointerStore<GuardVision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardVision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardVision>.NativeClassPtr);
			GuardVision.NativeFieldInfoPtr_seeLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "seeLayers");
			GuardVision.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "player");
			GuardVision.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "myPos");
			GuardVision.NativeFieldInfoPtr_searchGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "searchGrid");
			GuardVision.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "state");
			GuardVision.NativeFieldInfoPtr_pState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "pState");
			GuardVision.NativeFieldInfoPtr_onScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "onScreen");
			GuardVision.NativeFieldInfoPtr_hBuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "hBuf");
			GuardVision.NativeFieldInfoPtr_vBuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "vBuf");
			GuardVision.NativeFieldInfoPtr_colArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "colArr");
			GuardVision.NativeFieldInfoPtr_seeMeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "seeMeter");
			GuardVision.NativeFieldInfoPtr_seeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "seeTimer");
			GuardVision.NativeFieldInfoPtr_squinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "squinting");
			GuardVision.NativeFieldInfoPtr_sightAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "sightAng");
			GuardVision.NativeFieldInfoPtr_igList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "igList");
			GuardVision.NativeFieldInfoPtr_layerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "layerList");
			GuardVision.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "pts");
			GuardVision.NativeFieldInfoPtr_wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "wait");
			GuardVision.NativeFieldInfoPtr_checkMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "checkMask");
			GuardVision.NativeFieldInfoPtr_ignoreLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "ignoreLayer");
			GuardVision.NativeFieldInfoPtr_lastCheckTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "lastCheckTime");
			GuardVision.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, 100665773);
			GuardVision.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, 100665774);
			GuardVision.NativeMethodInfoPtr_Scan_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, 100665775);
			GuardVision.NativeMethodInfoPtr_CheckForPlayer_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, 100665776);
			GuardVision.NativeMethodInfoPtr_PlayerCast_Public_Boolean_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, 100665777);
			GuardVision.NativeMethodInfoPtr_PrayCast_Public_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, 100665778);
			GuardVision.NativeMethodInfoPtr_SayHey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, 100665779);
			GuardVision.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, 100665780);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0008B7CC File Offset: 0x000899CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65936, XrefRangeEnd = 65994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0008B800 File Offset: 0x00089A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65994, XrefRangeEnd = 66002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0008B834 File Offset: 0x00089A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66002, XrefRangeEnd = 66005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Scan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision.NativeMethodInfoPtr_Scan_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0008B874 File Offset: 0x00089A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66036, RefRangeEnd = 66037, XrefRangeStart = 66005, XrefRangeEnd = 66036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForPlayer(Vector2 pPos, float customDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref customDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision.NativeMethodInfoPtr_CheckForPlayer_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0008B8C0 File Offset: 0x00089AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66121, RefRangeEnd = 66122, XrefRangeStart = 66037, XrefRangeEnd = 66121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PlayerCast(Vector2 a, Vector2 b, float rad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision.NativeMethodInfoPtr_PlayerCast_Public_Boolean_Vector2_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x0008B928 File Offset: 0x00089B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66198, RefRangeEnd = 66199, XrefRangeStart = 66122, XrefRangeEnd = 66198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PrayCast(Vector2 a, Vector2 b)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision.NativeMethodInfoPtr_PrayCast_Public_Boolean_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0008B980 File Offset: 0x00089B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66199, XrefRangeEnd = 66202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision.NativeMethodInfoPtr_SayHey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0008B9B4 File Offset: 0x00089BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66202, XrefRangeEnd = 66208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardVision()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardVision>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00015A56 File Offset: 0x00013C56
		public GuardVision(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x0008B9F0 File Offset: 0x00089BF0
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x00015A5F File Offset: 0x00013C5F
		public unsafe LayerMask seeLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_seeLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_seeLayers)) = value;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x0008BA18 File Offset: 0x00089C18
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x00015A7A File Offset: 0x00013C7A
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x0008BA48 File Offset: 0x00089C48
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x00015A99 File Offset: 0x00013C99
		public unsafe Vector2 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x0008BA70 File Offset: 0x00089C70
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x00015AB4 File Offset: 0x00013CB4
		public unsafe SearchGrid searchGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_searchGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_searchGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x0008BAA0 File Offset: 0x00089CA0
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x00015AD3 File Offset: 0x00013CD3
		public unsafe GuardState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x0008BAD0 File Offset: 0x00089CD0
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x00015AF2 File Offset: 0x00013CF2
		public unsafe PlayerState pState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_pState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_pState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x0008BB00 File Offset: 0x00089D00
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x00015B11 File Offset: 0x00013D11
		public unsafe bool onScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_onScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_onScreen)) = value;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x0008BB28 File Offset: 0x00089D28
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x00015B2C File Offset: 0x00013D2C
		public unsafe float hBuf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_hBuf);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_hBuf)) = value;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x0008BB50 File Offset: 0x00089D50
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x00015B47 File Offset: 0x00013D47
		public unsafe float vBuf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_vBuf);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_vBuf)) = value;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x0008BB78 File Offset: 0x00089D78
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00015B62 File Offset: 0x00013D62
		public unsafe Il2CppReferenceArray<Collider2D> colArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_colArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_colArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x0008BBA8 File Offset: 0x00089DA8
		// (set) Token: 0x06001F15 RID: 7957 RVA: 0x00015B81 File Offset: 0x00013D81
		public unsafe int seeMeter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_seeMeter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_seeMeter)) = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x0008BBD0 File Offset: 0x00089DD0
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x00015B9C File Offset: 0x00013D9C
		public unsafe float seeTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_seeTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_seeTimer)) = value;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x0008BBF8 File Offset: 0x00089DF8
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x00015BB7 File Offset: 0x00013DB7
		public unsafe bool squinting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_squinting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_squinting)) = value;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x0008BC20 File Offset: 0x00089E20
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00015BD2 File Offset: 0x00013DD2
		public unsafe float sightAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_sightAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_sightAng)) = value;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x0008BC48 File Offset: 0x00089E48
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x00015BED File Offset: 0x00013DED
		public unsafe List<GameObject> igList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_igList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_igList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x0008BC78 File Offset: 0x00089E78
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x00015C0C File Offset: 0x00013E0C
		public unsafe List<int> layerList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_layerList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_layerList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x0008BCA8 File Offset: 0x00089EA8
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x00015C2B File Offset: 0x00013E2B
		public unsafe Il2CppStructArray<Vector2> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x0008BCD8 File Offset: 0x00089ED8
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x00015C4A File Offset: 0x00013E4A
		public unsafe WaitForSeconds wait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_wait);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_wait), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x0008BD08 File Offset: 0x00089F08
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00015C69 File Offset: 0x00013E69
		public unsafe int checkMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_checkMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_checkMask)) = value;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0008BD30 File Offset: 0x00089F30
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x00015C84 File Offset: 0x00013E84
		public unsafe int ignoreLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_ignoreLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_ignoreLayer)) = value;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0008BD58 File Offset: 0x00089F58
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x00015C9F File Offset: 0x00013E9F
		public unsafe float lastCheckTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_lastCheckTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision.NativeFieldInfoPtr_lastCheckTime)) = value;
			}
		}

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeFieldInfoPtr_seeLayers;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeFieldInfoPtr_searchGrid;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeFieldInfoPtr_pState;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeFieldInfoPtr_onScreen;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeFieldInfoPtr_hBuf;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeFieldInfoPtr_vBuf;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeFieldInfoPtr_colArr;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeFieldInfoPtr_seeMeter;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeFieldInfoPtr_seeTimer;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeFieldInfoPtr_squinting;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeFieldInfoPtr_sightAng;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeFieldInfoPtr_igList;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeFieldInfoPtr_layerList;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeFieldInfoPtr_wait;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeFieldInfoPtr_checkMask;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeFieldInfoPtr_ignoreLayer;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeFieldInfoPtr_lastCheckTime;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_Scan_Private_IEnumerator_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_CheckForPlayer_Public_Void_Vector2_Single_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_PlayerCast_Public_Boolean_Vector2_Vector2_Single_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_PrayCast_Public_Boolean_Vector2_Vector2_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_SayHey_Public_Void_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200030B RID: 779
		[ObfuscatedName("GuardVision+<Scan>d__23")]
		public sealed class _Scan_d__23 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F9A RID: 20378 RVA: 0x0012320C File Offset: 0x0012140C
			// Note: this type is marked as 'beforefieldinit'.
			static _Scan_d__23()
			{
				Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuardVision>.NativeClassPtr, "<Scan>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr);
				GuardVision._Scan_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr, "<>1__state");
				GuardVision._Scan_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr, "<>2__current");
				GuardVision._Scan_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr, "<>4__this");
				GuardVision._Scan_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr, 100665781);
				GuardVision._Scan_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr, 100665782);
				GuardVision._Scan_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr, 100665783);
				GuardVision._Scan_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr, 100665784);
				GuardVision._Scan_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr, 100665785);
				GuardVision._Scan_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr, 100665786);
			}

			// Token: 0x06004F9B RID: 20379 RVA: 0x001232EC File Offset: 0x001214EC
			[CallerCount(0)]
			public unsafe _Scan_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardVision._Scan_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision._Scan_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F9C RID: 20380 RVA: 0x00123334 File Offset: 0x00121534
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision._Scan_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F9D RID: 20381 RVA: 0x00123368 File Offset: 0x00121568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65929, XrefRangeEnd = 65931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision._Scan_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D06 RID: 7430
			// (get) Token: 0x06004F9E RID: 20382 RVA: 0x001233A4 File Offset: 0x001215A4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision._Scan_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F9F RID: 20383 RVA: 0x001233E4 File Offset: 0x001215E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65931, XrefRangeEnd = 65936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision._Scan_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D07 RID: 7431
			// (get) Token: 0x06004FA0 RID: 20384 RVA: 0x00123418 File Offset: 0x00121618
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardVision._Scan_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FA1 RID: 20385 RVA: 0x0002E8C3 File Offset: 0x0002CAC3
			public _Scan_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D03 RID: 7427
			// (get) Token: 0x06004FA2 RID: 20386 RVA: 0x00123458 File Offset: 0x00121658
			// (set) Token: 0x06004FA3 RID: 20387 RVA: 0x0002E8CC File Offset: 0x0002CACC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision._Scan_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision._Scan_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D04 RID: 7428
			// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x00123480 File Offset: 0x00121680
			// (set) Token: 0x06004FA5 RID: 20389 RVA: 0x0002E8E7 File Offset: 0x0002CAE7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision._Scan_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision._Scan_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D05 RID: 7429
			// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x001234B0 File Offset: 0x001216B0
			// (set) Token: 0x06004FA7 RID: 20391 RVA: 0x0002E906 File Offset: 0x0002CB06
			public unsafe GuardVision __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision._Scan_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardVision>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardVision._Scan_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003470 RID: 13424
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003471 RID: 13425
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003472 RID: 13426
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003473 RID: 13427
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003474 RID: 13428
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003475 RID: 13429
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003476 RID: 13430
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003477 RID: 13431
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003478 RID: 13432
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
