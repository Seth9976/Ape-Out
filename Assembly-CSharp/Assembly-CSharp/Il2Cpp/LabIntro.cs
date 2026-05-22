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
	// Token: 0x02000116 RID: 278
	public class LabIntro : MonoBehaviour
	{
		// Token: 0x060020B2 RID: 8370 RVA: 0x0008FBBC File Offset: 0x0008DDBC
		// Note: this type is marked as 'beforefieldinit'.
		static LabIntro()
		{
			Il2CppClassPointerStore<LabIntro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LabIntro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabIntro>.NativeClassPtr);
			LabIntro.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "line");
			LabIntro.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "positions");
			LabIntro.NativeFieldInfoPtr_camStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "camStartPos");
			LabIntro.NativeFieldInfoPtr_camEndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "camEndPos");
			LabIntro.NativeFieldInfoPtr_camTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "camTime");
			LabIntro.NativeFieldInfoPtr_CamCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "CamCurve");
			LabIntro.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "anim");
			LabIntro.NativeFieldInfoPtr_blackQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "blackQuad");
			LabIntro.NativeFieldInfoPtr_grimeyBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "grimeyBlack");
			LabIntro.NativeFieldInfoPtr_lightsUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "lightsUp");
			LabIntro.NativeFieldInfoPtr_stickSnds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "stickSnds");
			LabIntro.NativeFieldInfoPtr_recordStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "recordStart");
			LabIntro.NativeFieldInfoPtr_gurneySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "gurneySound");
			LabIntro.NativeFieldInfoPtr_gunShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "gunShot");
			LabIntro.NativeFieldInfoPtr_fall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "fall");
			LabIntro.NativeFieldInfoPtr_jungleSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "jungleSource");
			LabIntro.NativeFieldInfoPtr_jungleFadeUpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "jungleFadeUpTime");
			LabIntro.NativeFieldInfoPtr_jungleFadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "jungleFadeOutTime");
			LabIntro.NativeFieldInfoPtr_zipper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "zipper");
			LabIntro.NativeFieldInfoPtr_chimpYell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "chimpYell");
			LabIntro.NativeFieldInfoPtr_recordNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "recordNoise");
			LabIntro.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, 100665891);
			LabIntro.NativeMethodInfoPtr_Intro_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, 100665892);
			LabIntro.NativeMethodInfoPtr_PlayStickSnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, 100665893);
			LabIntro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, 100665894);
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0008FDE0 File Offset: 0x0008DFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68040, XrefRangeEnd = 68068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabIntro.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0008FE14 File Offset: 0x0008E014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68068, XrefRangeEnd = 68071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Intro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabIntro.NativeMethodInfoPtr_Intro_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x0008FE54 File Offset: 0x0008E054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68071, XrefRangeEnd = 68079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStickSnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabIntro.NativeMethodInfoPtr_PlayStickSnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x0008FE88 File Offset: 0x0008E088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabIntro()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabIntro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabIntro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00016D76 File Offset: 0x00014F76
		public LabIntro(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0008FEC4 File Offset: 0x0008E0C4
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x00016D7F File Offset: 0x00014F7F
		public unsafe LineRenderer line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_line);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0008FEF4 File Offset: 0x0008E0F4
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x00016D9E File Offset: 0x00014F9E
		public unsafe Il2CppStructArray<Vector2> positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x0008FF24 File Offset: 0x0008E124
		// (set) Token: 0x060020BD RID: 8381 RVA: 0x00016DBD File Offset: 0x00014FBD
		public unsafe Vector2 camStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_camStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_camStartPos)) = value;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x0008FF4C File Offset: 0x0008E14C
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x00016DD8 File Offset: 0x00014FD8
		public unsafe Vector2 camEndPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_camEndPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_camEndPos)) = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0008FF74 File Offset: 0x0008E174
		// (set) Token: 0x060020C1 RID: 8385 RVA: 0x00016DF3 File Offset: 0x00014FF3
		public unsafe float camTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_camTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_camTime)) = value;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0008FF9C File Offset: 0x0008E19C
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x00016E0E File Offset: 0x0001500E
		public unsafe AnimationCurve CamCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_CamCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_CamCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0008FFCC File Offset: 0x0008E1CC
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x00016E2D File Offset: 0x0001502D
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x0008FFFC File Offset: 0x0008E1FC
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x00016E4C File Offset: 0x0001504C
		public unsafe GameObject blackQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_blackQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_blackQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x0009002C File Offset: 0x0008E22C
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x00016E6B File Offset: 0x0001506B
		public unsafe Material grimeyBlack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_grimeyBlack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_grimeyBlack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x0009005C File Offset: 0x0008E25C
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x00016E8A File Offset: 0x0001508A
		public unsafe AudioClip lightsUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_lightsUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_lightsUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x0009008C File Offset: 0x0008E28C
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x00016EA9 File Offset: 0x000150A9
		public unsafe Il2CppReferenceArray<AudioClip> stickSnds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_stickSnds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_stickSnds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x000900BC File Offset: 0x0008E2BC
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x00016EC8 File Offset: 0x000150C8
		public unsafe AudioClip recordStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_recordStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_recordStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x000900EC File Offset: 0x0008E2EC
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x00016EE7 File Offset: 0x000150E7
		public unsafe AudioClip gurneySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_gurneySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_gurneySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0009011C File Offset: 0x0008E31C
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x00016F06 File Offset: 0x00015106
		public unsafe AudioClip gunShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_gunShot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_gunShot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x0009014C File Offset: 0x0008E34C
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x00016F25 File Offset: 0x00015125
		public unsafe AudioClip fall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_fall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_fall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x0009017C File Offset: 0x0008E37C
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x00016F44 File Offset: 0x00015144
		public unsafe AudioSource jungleSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_jungleSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_jungleSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x000901AC File Offset: 0x0008E3AC
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x00016F63 File Offset: 0x00015163
		public unsafe float jungleFadeUpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_jungleFadeUpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_jungleFadeUpTime)) = value;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x000901D4 File Offset: 0x0008E3D4
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x00016F7E File Offset: 0x0001517E
		public unsafe float jungleFadeOutTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_jungleFadeOutTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_jungleFadeOutTime)) = value;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x000901FC File Offset: 0x0008E3FC
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x00016F99 File Offset: 0x00015199
		public unsafe AudioClip zipper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_zipper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_zipper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x0009022C File Offset: 0x0008E42C
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x00016FB8 File Offset: 0x000151B8
		public unsafe AudioClip chimpYell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_chimpYell);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_chimpYell), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x0009025C File Offset: 0x0008E45C
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x00016FD7 File Offset: 0x000151D7
		public unsafe AudioSource recordNoise
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_recordNoise);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro.NativeFieldInfoPtr_recordNoise), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeFieldInfoPtr_camStartPos;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeFieldInfoPtr_camEndPos;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeFieldInfoPtr_camTime;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeFieldInfoPtr_CamCurve;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeFieldInfoPtr_blackQuad;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeFieldInfoPtr_grimeyBlack;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeFieldInfoPtr_lightsUp;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeFieldInfoPtr_stickSnds;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeFieldInfoPtr_recordStart;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeFieldInfoPtr_gurneySound;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeFieldInfoPtr_gunShot;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeFieldInfoPtr_fall;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeFieldInfoPtr_jungleSource;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeFieldInfoPtr_jungleFadeUpTime;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeFieldInfoPtr_jungleFadeOutTime;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeFieldInfoPtr_zipper;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeFieldInfoPtr_chimpYell;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeFieldInfoPtr_recordNoise;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_Intro_Public_IEnumerator_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_PlayStickSnd_Private_Void_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000313 RID: 787
		[ObfuscatedName("LabIntro+<Intro>d__22")]
		public sealed class _Intro_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x06004FF4 RID: 20468 RVA: 0x001243B8 File Offset: 0x001225B8
			// Note: this type is marked as 'beforefieldinit'.
			static _Intro_d__22()
			{
				Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LabIntro>.NativeClassPtr, "<Intro>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr);
				LabIntro._Intro_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, "<>1__state");
				LabIntro._Intro_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, "<>2__current");
				LabIntro._Intro_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, "<>4__this");
				LabIntro._Intro_d__22.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, "<timer>5__2");
				LabIntro._Intro_d__22.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, "<i>5__3");
				LabIntro._Intro_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, 100665895);
				LabIntro._Intro_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, 100665896);
				LabIntro._Intro_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, 100665897);
				LabIntro._Intro_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, 100665898);
				LabIntro._Intro_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, 100665899);
				LabIntro._Intro_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr, 100665900);
			}

			// Token: 0x06004FF5 RID: 20469 RVA: 0x001244C0 File Offset: 0x001226C0
			[CallerCount(0)]
			public unsafe _Intro_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabIntro._Intro_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabIntro._Intro_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FF6 RID: 20470 RVA: 0x00124508 File Offset: 0x00122708
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabIntro._Intro_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FF7 RID: 20471 RVA: 0x0012453C File Offset: 0x0012273C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67913, XrefRangeEnd = 68035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabIntro._Intro_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D29 RID: 7465
			// (get) Token: 0x06004FF8 RID: 20472 RVA: 0x00124578 File Offset: 0x00122778
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabIntro._Intro_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FF9 RID: 20473 RVA: 0x001245B8 File Offset: 0x001227B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68035, XrefRangeEnd = 68040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabIntro._Intro_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D2A RID: 7466
			// (get) Token: 0x06004FFA RID: 20474 RVA: 0x001245EC File Offset: 0x001227EC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabIntro._Intro_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FFB RID: 20475 RVA: 0x0002EB60 File Offset: 0x0002CD60
			public _Intro_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D24 RID: 7460
			// (get) Token: 0x06004FFC RID: 20476 RVA: 0x0012462C File Offset: 0x0012282C
			// (set) Token: 0x06004FFD RID: 20477 RVA: 0x0002EB69 File Offset: 0x0002CD69
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro._Intro_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro._Intro_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D25 RID: 7461
			// (get) Token: 0x06004FFE RID: 20478 RVA: 0x00124654 File Offset: 0x00122854
			// (set) Token: 0x06004FFF RID: 20479 RVA: 0x0002EB84 File Offset: 0x0002CD84
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro._Intro_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro._Intro_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D26 RID: 7462
			// (get) Token: 0x06005000 RID: 20480 RVA: 0x00124684 File Offset: 0x00122884
			// (set) Token: 0x06005001 RID: 20481 RVA: 0x0002EBA3 File Offset: 0x0002CDA3
			public unsafe LabIntro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro._Intro_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabIntro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro._Intro_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D27 RID: 7463
			// (get) Token: 0x06005002 RID: 20482 RVA: 0x001246B4 File Offset: 0x001228B4
			// (set) Token: 0x06005003 RID: 20483 RVA: 0x0002EBC2 File Offset: 0x0002CDC2
			public unsafe float _timer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro._Intro_d__22.NativeFieldInfoPtr__timer_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro._Intro_d__22.NativeFieldInfoPtr__timer_5__2)) = value;
				}
			}

			// Token: 0x17001D28 RID: 7464
			// (get) Token: 0x06005004 RID: 20484 RVA: 0x001246DC File Offset: 0x001228DC
			// (set) Token: 0x06005005 RID: 20485 RVA: 0x0002EBDD File Offset: 0x0002CDDD
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro._Intro_d__22.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabIntro._Intro_d__22.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040034C1 RID: 13505
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040034C2 RID: 13506
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040034C3 RID: 13507
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040034C4 RID: 13508
			private static readonly IntPtr NativeFieldInfoPtr__timer_5__2;

			// Token: 0x040034C5 RID: 13509
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040034C6 RID: 13510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040034C7 RID: 13511
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034C8 RID: 13512
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040034C9 RID: 13513
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040034CA RID: 13514
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034CB RID: 13515
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
