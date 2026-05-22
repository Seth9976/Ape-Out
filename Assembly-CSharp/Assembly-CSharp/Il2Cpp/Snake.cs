using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000195 RID: 405
	public class Snake : MonoBehaviour
	{
		// Token: 0x06002F8A RID: 12170 RVA: 0x000B74A8 File Offset: 0x000B56A8
		// Note: this type is marked as 'beforefieldinit'.
		static Snake()
		{
			Il2CppClassPointerStore<Snake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Snake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snake>.NativeClassPtr);
			Snake.NativeFieldInfoPtr_trueDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "trueDir");
			Snake.NativeFieldInfoPtr_dirOffSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "dirOffSet");
			Snake.NativeFieldInfoPtr_links = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "links");
			Snake.NativeFieldInfoPtr_link = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "link");
			Snake.NativeFieldInfoPtr_linkNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "linkNum");
			Snake.NativeFieldInfoPtr_spd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "spd");
			Snake.NativeFieldInfoPtr_nextAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "nextAnchor");
			Snake.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "dest");
			Snake.NativeFieldInfoPtr_curVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "curVel");
			Snake.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "up");
			Snake.NativeFieldInfoPtr_sizeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "sizeCurve");
			Snake.NativeFieldInfoPtr_sineSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "sineSpd");
			Snake.NativeFieldInfoPtr_prevPosList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "prevPosList");
			Snake.NativeFieldInfoPtr_lineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "lineRenderer");
			Snake.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "rb");
			Snake.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "head");
			Snake.NativeFieldInfoPtr_minDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "minDist");
			Snake.NativeFieldInfoPtr_maxDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "maxDist");
			Snake.NativeFieldInfoPtr_pf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "pf");
			Snake.NativeFieldInfoPtr_prevPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "prevPos");
			Snake.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "amplitude");
			Snake.NativeFieldInfoPtr_awake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "awake");
			Snake.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100667013);
			Snake.NativeMethodInfoPtr_OnUncaged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100667014);
			Snake.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100667015);
			Snake.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100667016);
			Snake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100667017);
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x000B76F4 File Offset: 0x000B58F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83392, XrefRangeEnd = 83430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x000B7728 File Offset: 0x000B5928
		[CallerCount(0)]
		public unsafe void OnUncaged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_OnUncaged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x000B775C File Offset: 0x000B595C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83430, XrefRangeEnd = 83479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x000B7790 File Offset: 0x000B5990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83479, XrefRangeEnd = 83488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x000B77C4 File Offset: 0x000B59C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Snake()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Snake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		public Snake(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x000B7800 File Offset: 0x000B5A00
		// (set) Token: 0x06002F92 RID: 12178 RVA: 0x00020CC1 File Offset: 0x0001EEC1
		public unsafe float trueDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_trueDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_trueDir)) = value;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x000B7828 File Offset: 0x000B5A28
		// (set) Token: 0x06002F94 RID: 12180 RVA: 0x00020CDC File Offset: 0x0001EEDC
		public unsafe float dirOffSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_dirOffSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_dirOffSet)) = value;
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x000B7850 File Offset: 0x000B5A50
		// (set) Token: 0x06002F96 RID: 12182 RVA: 0x00020CF7 File Offset: 0x0001EEF7
		public unsafe Il2CppStructArray<Vector3> links
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_links);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_links), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x000B7880 File Offset: 0x000B5A80
		// (set) Token: 0x06002F98 RID: 12184 RVA: 0x00020D16 File Offset: 0x0001EF16
		public unsafe GameObject link
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_link);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_link), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06002F99 RID: 12185 RVA: 0x000B78B0 File Offset: 0x000B5AB0
		// (set) Token: 0x06002F9A RID: 12186 RVA: 0x00020D35 File Offset: 0x0001EF35
		public unsafe int linkNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_linkNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_linkNum)) = value;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x000B78D8 File Offset: 0x000B5AD8
		// (set) Token: 0x06002F9C RID: 12188 RVA: 0x00020D50 File Offset: 0x0001EF50
		public unsafe float spd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_spd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_spd)) = value;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x000B7900 File Offset: 0x000B5B00
		// (set) Token: 0x06002F9E RID: 12190 RVA: 0x00020D6B File Offset: 0x0001EF6B
		public unsafe Vector2 nextAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_nextAnchor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_nextAnchor)) = value;
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x000B7928 File Offset: 0x000B5B28
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x00020D86 File Offset: 0x0001EF86
		public unsafe Vector2 dest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_dest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_dest)) = value;
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x000B7950 File Offset: 0x000B5B50
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x00020DA1 File Offset: 0x0001EFA1
		public unsafe float curVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_curVel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_curVel)) = value;
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x000B7978 File Offset: 0x000B5B78
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x00020DBC File Offset: 0x0001EFBC
		public unsafe bool up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_up);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_up)) = value;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x000B79A0 File Offset: 0x000B5BA0
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x00020DD7 File Offset: 0x0001EFD7
		public unsafe AnimationCurve sizeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_sizeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_sizeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x000B79D0 File Offset: 0x000B5BD0
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x00020DF6 File Offset: 0x0001EFF6
		public unsafe float sineSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_sineSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_sineSpd)) = value;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x000B79F8 File Offset: 0x000B5BF8
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x00020E11 File Offset: 0x0001F011
		public unsafe Il2CppStructArray<Vector3> prevPosList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_prevPosList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_prevPosList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x000B7A28 File Offset: 0x000B5C28
		// (set) Token: 0x06002FAC RID: 12204 RVA: 0x00020E30 File Offset: 0x0001F030
		public unsafe LineRenderer lineRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_lineRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_lineRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x000B7A58 File Offset: 0x000B5C58
		// (set) Token: 0x06002FAE RID: 12206 RVA: 0x00020E4F File Offset: 0x0001F04F
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x000B7A88 File Offset: 0x000B5C88
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x00020E6E File Offset: 0x0001F06E
		public unsafe Transform head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x000B7AB8 File Offset: 0x000B5CB8
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x00020E8D File Offset: 0x0001F08D
		public unsafe float minDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_minDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_minDist)) = value;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x000B7AE0 File Offset: 0x000B5CE0
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x00020EA8 File Offset: 0x0001F0A8
		public unsafe float maxDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_maxDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_maxDist)) = value;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x000B7B08 File Offset: 0x000B5D08
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x00020EC3 File Offset: 0x0001F0C3
		public unsafe PathFollower pf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_pf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathFollower>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_pf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x000B7B38 File Offset: 0x000B5D38
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x00020EE2 File Offset: 0x0001F0E2
		public unsafe Vector3 prevPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_prevPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_prevPos)) = value;
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x000B7B60 File Offset: 0x000B5D60
		// (set) Token: 0x06002FBA RID: 12218 RVA: 0x00020EFD File Offset: 0x0001F0FD
		public unsafe float amplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_amplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_amplitude)) = value;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x000B7B88 File Offset: 0x000B5D88
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x00020F18 File Offset: 0x0001F118
		public unsafe bool awake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_awake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_awake)) = value;
			}
		}

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeFieldInfoPtr_trueDir;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeFieldInfoPtr_dirOffSet;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeFieldInfoPtr_links;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeFieldInfoPtr_link;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeFieldInfoPtr_linkNum;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeFieldInfoPtr_spd;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeFieldInfoPtr_nextAnchor;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeFieldInfoPtr_dest;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeFieldInfoPtr_curVel;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeFieldInfoPtr_sizeCurve;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeFieldInfoPtr_sineSpd;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeFieldInfoPtr_prevPosList;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeFieldInfoPtr_lineRenderer;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeFieldInfoPtr_minDist;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeFieldInfoPtr_maxDist;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeFieldInfoPtr_pf;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeFieldInfoPtr_prevPos;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeFieldInfoPtr_amplitude;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeFieldInfoPtr_awake;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_OnUncaged_Private_Void_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
