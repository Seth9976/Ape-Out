using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Il2Cpp
{
	// Token: 0x02000180 RID: 384
	public class SetFPS : MonoBehaviour
	{
		// Token: 0x06002DB2 RID: 11698 RVA: 0x000B241C File Offset: 0x000B061C
		// Note: this type is marked as 'beforefieldinit'.
		static SetFPS()
		{
			Il2CppClassPointerStore<SetFPS>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SetFPS");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetFPS>.NativeClassPtr);
			SetFPS.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, "anim");
			SetFPS.NativeFieldInfoPtr_lastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, "lastTime");
			SetFPS.NativeFieldInfoPtr_trueTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, "trueTime");
			SetFPS.NativeFieldInfoPtr_fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, "fps");
			SetFPS.NativeFieldInfoPtr_playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, "playing");
			SetFPS.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, "speed");
			SetFPS.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, "duration");
			SetFPS.NativeFieldInfoPtr_timelineTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, "timelineTime");
			SetFPS.NativeFieldInfoPtr_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, "dir");
			SetFPS.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, 100666872);
			SetFPS.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, 100666873);
			SetFPS.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, 100666874);
			SetFPS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetFPS>.NativeClassPtr, 100666875);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x000B2550 File Offset: 0x000B0750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81355, XrefRangeEnd = 81371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetFPS.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x000B2584 File Offset: 0x000B0784
		[CallerCount(0)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetFPS.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000B25B8 File Offset: 0x000B07B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81371, XrefRangeEnd = 81388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetFPS.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000B25EC File Offset: 0x000B07EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetFPS()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetFPS>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetFPS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x0001F9AA File Offset: 0x0001DBAA
		public SetFPS(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x000B2628 File Offset: 0x000B0828
		// (set) Token: 0x06002DB9 RID: 11705 RVA: 0x0001F9B3 File Offset: 0x0001DBB3
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06002DBA RID: 11706 RVA: 0x000B2658 File Offset: 0x000B0858
		// (set) Token: 0x06002DBB RID: 11707 RVA: 0x0001F9D2 File Offset: 0x0001DBD2
		public unsafe float lastTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_lastTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_lastTime)) = value;
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x000B2680 File Offset: 0x000B0880
		// (set) Token: 0x06002DBD RID: 11709 RVA: 0x0001F9ED File Offset: 0x0001DBED
		public unsafe float trueTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_trueTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_trueTime)) = value;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x000B26A8 File Offset: 0x000B08A8
		// (set) Token: 0x06002DBF RID: 11711 RVA: 0x0001FA08 File Offset: 0x0001DC08
		public unsafe int fps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_fps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_fps)) = value;
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06002DC0 RID: 11712 RVA: 0x000B26D0 File Offset: 0x000B08D0
		// (set) Token: 0x06002DC1 RID: 11713 RVA: 0x0001FA23 File Offset: 0x0001DC23
		public unsafe bool playing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_playing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_playing)) = value;
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06002DC2 RID: 11714 RVA: 0x000B26F8 File Offset: 0x000B08F8
		// (set) Token: 0x06002DC3 RID: 11715 RVA: 0x0001FA3E File Offset: 0x0001DC3E
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x000B2720 File Offset: 0x000B0920
		// (set) Token: 0x06002DC5 RID: 11717 RVA: 0x0001FA59 File Offset: 0x0001DC59
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x000B2748 File Offset: 0x000B0948
		// (set) Token: 0x06002DC7 RID: 11719 RVA: 0x0001FA74 File Offset: 0x0001DC74
		public unsafe bool timelineTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_timelineTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_timelineTime)) = value;
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x000B2770 File Offset: 0x000B0970
		// (set) Token: 0x06002DC9 RID: 11721 RVA: 0x0001FA8F File Offset: 0x0001DC8F
		public unsafe PlayableDirector dir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_dir);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableDirector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetFPS.NativeFieldInfoPtr_dir), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeFieldInfoPtr_lastTime;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeFieldInfoPtr_trueTime;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeFieldInfoPtr_fps;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeFieldInfoPtr_playing;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeFieldInfoPtr_timelineTime;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeFieldInfoPtr_dir;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
