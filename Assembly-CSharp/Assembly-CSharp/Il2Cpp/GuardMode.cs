using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000FB RID: 251
	public class GuardMode : global::Il2CppSystem.Object
	{
		// Token: 0x06001D77 RID: 7543 RVA: 0x00087144 File Offset: 0x00085344
		// Note: this type is marked as 'beforefieldinit'.
		static GuardMode()
		{
			Il2CppClassPointerStore<GuardMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardMode>.NativeClassPtr);
			GuardMode.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "state");
			GuardMode.NativeFieldInfoPtr_seeing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "seeing");
			GuardMode.NativeFieldInfoPtr_moving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "moving");
			GuardMode.NativeFieldInfoPtr_aiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "aiming");
			GuardMode.NativeFieldInfoPtr_attacking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "attacking");
			GuardMode.NativeFieldInfoPtr_panicShooting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "panicShooting");
			GuardMode.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "forced");
			GuardMode.NativeFieldInfoPtr_nextMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "nextMode");
			GuardMode.NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "layer");
			GuardMode.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "moveSpeed");
			GuardMode.NativeFieldInfoPtr_rotRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "rotRate");
			GuardMode.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "priority");
			GuardMode.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, "anim");
			GuardMode.NativeMethodInfoPtr_Init_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, 100665676);
			GuardMode.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, 100665677);
			GuardMode.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, 100665678);
			GuardMode.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, 100665679);
			GuardMode.NativeMethodInfoPtr_FollowPath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, 100665680);
			GuardMode.NativeMethodInfoPtr_FollowPathNoDamp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, 100665681);
			GuardMode.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, 100665682);
			GuardMode.NativeMethodInfoPtr_StalkCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, 100665683);
			GuardMode.NativeMethodInfoPtr_OnCollEnter_Public_Virtual_New_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, 100665684);
			GuardMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardMode>.NativeClassPtr, 100665685);
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00087340 File Offset: 0x00085540
		[CallerCount(0)]
		public unsafe void Init(GuardState st, float mSpd, float rRate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardMode.NativeMethodInfoPtr_Init_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x000873A0 File Offset: 0x000855A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardMode.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x000873DC File Offset: 0x000855DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardMode.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00087418 File Offset: 0x00085618
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardMode.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00087454 File Offset: 0x00085654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64529, RefRangeEnd = 64530, XrefRangeStart = 64522, XrefRangeEnd = 64529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FollowPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardMode.NativeMethodInfoPtr_FollowPath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00087488 File Offset: 0x00085688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64530, XrefRangeEnd = 64537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FollowPathNoDamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardMode.NativeMethodInfoPtr_FollowPathNoDamp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000874BC File Offset: 0x000856BC
		[CallerCount(0)]
		public unsafe virtual bool ShouldAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardMode.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x00087504 File Offset: 0x00085704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64537, XrefRangeEnd = 64556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StalkCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardMode.NativeMethodInfoPtr_StalkCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00087538 File Offset: 0x00085738
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCollEnter(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardMode.NativeMethodInfoPtr_OnCollEnter_Public_Virtual_New_Void_Collision2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00087588 File Offset: 0x00085788
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardMode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardMode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x00014B14 File Offset: 0x00012D14
		public GuardMode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x000875C4 File Offset: 0x000857C4
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x00014B1D File Offset: 0x00012D1D
		public unsafe GuardState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x000875F4 File Offset: 0x000857F4
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x00014B3C File Offset: 0x00012D3C
		public unsafe bool seeing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_seeing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_seeing)) = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x0008761C File Offset: 0x0008581C
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x00014B57 File Offset: 0x00012D57
		public unsafe bool moving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_moving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_moving)) = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x00087644 File Offset: 0x00085844
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x00014B72 File Offset: 0x00012D72
		public unsafe bool aiming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_aiming);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_aiming)) = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0008766C File Offset: 0x0008586C
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x00014B8D File Offset: 0x00012D8D
		public unsafe bool attacking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_attacking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_attacking)) = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00087694 File Offset: 0x00085894
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x00014BA8 File Offset: 0x00012DA8
		public unsafe bool panicShooting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_panicShooting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_panicShooting)) = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x000876BC File Offset: 0x000858BC
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00014BC3 File Offset: 0x00012DC3
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x000876E4 File Offset: 0x000858E4
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x00014BDE File Offset: 0x00012DDE
		public unsafe GuardMode nextMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_nextMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_nextMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00087714 File Offset: 0x00085914
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00014BFD File Offset: 0x00012DFD
		public unsafe int layer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_layer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_layer)) = value;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x0008773C File Offset: 0x0008593C
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x00014C18 File Offset: 0x00012E18
		public unsafe float moveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_moveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_moveSpeed)) = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00087764 File Offset: 0x00085964
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x00014C33 File Offset: 0x00012E33
		public unsafe float rotRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_rotRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_rotRate)) = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0008778C File Offset: 0x0008598C
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x00014C4E File Offset: 0x00012E4E
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000877B4 File Offset: 0x000859B4
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x00014C69 File Offset: 0x00012E69
		public unsafe RuntimeAnimatorController anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardMode.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeFieldInfoPtr_seeing;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeFieldInfoPtr_moving;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeFieldInfoPtr_aiming;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeFieldInfoPtr_attacking;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeFieldInfoPtr_panicShooting;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeFieldInfoPtr_nextMode;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeFieldInfoPtr_layer;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeFieldInfoPtr_rotRate;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_GuardState_Single_Single_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_New_Void_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_FollowPath_Public_Void_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_FollowPathNoDamp_Public_Void_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_ShouldAnim_Public_Virtual_New_Boolean_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_StalkCheck_Public_Void_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_OnCollEnter_Public_Virtual_New_Void_Collision2D_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
