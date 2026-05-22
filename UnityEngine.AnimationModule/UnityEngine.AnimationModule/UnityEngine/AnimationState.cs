using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public sealed class AnimationState : TrackedReference
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00006630 File Offset: 0x00004830
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationState()
		{
			Il2CppClassPointerStore<AnimationState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimationState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationState>.NativeClassPtr);
			AnimationState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationState>.NativeClassPtr, 100663319);
			AnimationState.get_enabledDelegateField = IL2CPP.ResolveICall<AnimationState.get_enabledDelegate>("UnityEngine.AnimationState::get_enabled");
			AnimationState.set_enabledDelegateField = IL2CPP.ResolveICall<AnimationState.set_enabledDelegate>("UnityEngine.AnimationState::set_enabled");
			AnimationState.get_weightDelegateField = IL2CPP.ResolveICall<AnimationState.get_weightDelegate>("UnityEngine.AnimationState::get_weight");
			AnimationState.set_weightDelegateField = IL2CPP.ResolveICall<AnimationState.set_weightDelegate>("UnityEngine.AnimationState::set_weight");
			AnimationState.get_wrapModeDelegateField = IL2CPP.ResolveICall<AnimationState.get_wrapModeDelegate>("UnityEngine.AnimationState::get_wrapMode");
			AnimationState.set_wrapModeDelegateField = IL2CPP.ResolveICall<AnimationState.set_wrapModeDelegate>("UnityEngine.AnimationState::set_wrapMode");
			AnimationState.get_timeDelegateField = IL2CPP.ResolveICall<AnimationState.get_timeDelegate>("UnityEngine.AnimationState::get_time");
			AnimationState.set_timeDelegateField = IL2CPP.ResolveICall<AnimationState.set_timeDelegate>("UnityEngine.AnimationState::set_time");
			AnimationState.get_normalizedTimeDelegateField = IL2CPP.ResolveICall<AnimationState.get_normalizedTimeDelegate>("UnityEngine.AnimationState::get_normalizedTime");
			AnimationState.set_normalizedTimeDelegateField = IL2CPP.ResolveICall<AnimationState.set_normalizedTimeDelegate>("UnityEngine.AnimationState::set_normalizedTime");
			AnimationState.get_speedDelegateField = IL2CPP.ResolveICall<AnimationState.get_speedDelegate>("UnityEngine.AnimationState::get_speed");
			AnimationState.set_speedDelegateField = IL2CPP.ResolveICall<AnimationState.set_speedDelegate>("UnityEngine.AnimationState::set_speed");
			AnimationState.get_normalizedSpeedDelegateField = IL2CPP.ResolveICall<AnimationState.get_normalizedSpeedDelegate>("UnityEngine.AnimationState::get_normalizedSpeed");
			AnimationState.set_normalizedSpeedDelegateField = IL2CPP.ResolveICall<AnimationState.set_normalizedSpeedDelegate>("UnityEngine.AnimationState::set_normalizedSpeed");
			AnimationState.get_lengthDelegateField = IL2CPP.ResolveICall<AnimationState.get_lengthDelegate>("UnityEngine.AnimationState::get_length");
			AnimationState.get_layerDelegateField = IL2CPP.ResolveICall<AnimationState.get_layerDelegate>("UnityEngine.AnimationState::get_layer");
			AnimationState.set_layerDelegateField = IL2CPP.ResolveICall<AnimationState.set_layerDelegate>("UnityEngine.AnimationState::set_layer");
			AnimationState.get_clipDelegateField = IL2CPP.ResolveICall<AnimationState.get_clipDelegate>("UnityEngine.AnimationState::get_clip");
			AnimationState.get_nameDelegateField = IL2CPP.ResolveICall<AnimationState.get_nameDelegate>("UnityEngine.AnimationState::get_name");
			AnimationState.set_nameDelegateField = IL2CPP.ResolveICall<AnimationState.set_nameDelegate>("UnityEngine.AnimationState::set_name");
			AnimationState.get_blendModeDelegateField = IL2CPP.ResolveICall<AnimationState.get_blendModeDelegate>("UnityEngine.AnimationState::get_blendMode");
			AnimationState.set_blendModeDelegateField = IL2CPP.ResolveICall<AnimationState.set_blendModeDelegate>("UnityEngine.AnimationState::set_blendMode");
			AnimationState.AddMixingTransformDelegateField = IL2CPP.ResolveICall<AnimationState.AddMixingTransformDelegate>("UnityEngine.AnimationState::AddMixingTransform");
			AnimationState.RemoveMixingTransformDelegateField = IL2CPP.ResolveICall<AnimationState.RemoveMixingTransformDelegate>("UnityEngine.AnimationState::RemoveMixingTransform");
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000067DC File Offset: 0x000049DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000237E File Offset: 0x0000057E
		public AnimationState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002387 File Offset: 0x00000587
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002399 File Offset: 0x00000599
		public bool enabled
		{
			get
			{
				return AnimationState.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000023AC File Offset: 0x000005AC
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000023BE File Offset: 0x000005BE
		public float weight
		{
			get
			{
				return AnimationState.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000023D1 File Offset: 0x000005D1
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000023E3 File Offset: 0x000005E3
		public WrapMode wrapMode
		{
			get
			{
				return AnimationState.get_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000023F6 File Offset: 0x000005F6
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002408 File Offset: 0x00000608
		public float time
		{
			get
			{
				return AnimationState.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000241B File Offset: 0x0000061B
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000242D File Offset: 0x0000062D
		public float normalizedTime
		{
			get
			{
				return AnimationState.get_normalizedTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_normalizedTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002440 File Offset: 0x00000640
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002452 File Offset: 0x00000652
		public float speed
		{
			get
			{
				return AnimationState.get_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002465 File Offset: 0x00000665
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002477 File Offset: 0x00000677
		public float normalizedSpeed
		{
			get
			{
				return AnimationState.get_normalizedSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_normalizedSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000248A File Offset: 0x0000068A
		public float length
		{
			get
			{
				return AnimationState.get_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000249C File Offset: 0x0000069C
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000024AE File Offset: 0x000006AE
		public int layer
		{
			get
			{
				return AnimationState.get_layerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_layerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00006818 File Offset: 0x00004A18
		public AnimationClip clip
		{
			get
			{
				IntPtr intPtr = AnimationState.get_clipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00006844 File Offset: 0x00004A44
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000024C1 File Offset: 0x000006C1
		public string name
		{
			get
			{
				IntPtr intPtr = AnimationState.get_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				AnimationState.set_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000024D9 File Offset: 0x000006D9
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000024EB File Offset: 0x000006EB
		public AnimationBlendMode blendMode
		{
			get
			{
				return AnimationState.get_blendModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationState.set_blendModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000024FE File Offset: 0x000006FE
		public void AddMixingTransform(Transform mix)
		{
			this.AddMixingTransform(mix, true);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000250A File Offset: 0x0000070A
		public void AddMixingTransform(Transform mix, bool recursive)
		{
			AnimationState.AddMixingTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mix), recursive);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002523 File Offset: 0x00000723
		public void RemoveMixingTransform(Transform mix)
		{
			AnimationState.RemoveMixingTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mix));
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000039 RID: 57
		private static readonly AnimationState.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly AnimationState.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly AnimationState.get_weightDelegate get_weightDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly AnimationState.set_weightDelegate set_weightDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly AnimationState.get_wrapModeDelegate get_wrapModeDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly AnimationState.set_wrapModeDelegate set_wrapModeDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly AnimationState.get_timeDelegate get_timeDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly AnimationState.set_timeDelegate set_timeDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly AnimationState.get_normalizedTimeDelegate get_normalizedTimeDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly AnimationState.set_normalizedTimeDelegate set_normalizedTimeDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly AnimationState.get_speedDelegate get_speedDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly AnimationState.set_speedDelegate set_speedDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly AnimationState.get_normalizedSpeedDelegate get_normalizedSpeedDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly AnimationState.set_normalizedSpeedDelegate set_normalizedSpeedDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly AnimationState.get_lengthDelegate get_lengthDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly AnimationState.get_layerDelegate get_layerDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly AnimationState.set_layerDelegate set_layerDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly AnimationState.get_clipDelegate get_clipDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly AnimationState.get_nameDelegate get_nameDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly AnimationState.set_nameDelegate set_nameDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly AnimationState.get_blendModeDelegate get_blendModeDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly AnimationState.set_blendModeDelegate set_blendModeDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly AnimationState.AddMixingTransformDelegate AddMixingTransformDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly AnimationState.RemoveMixingTransformDelegate RemoveMixingTransformDelegateField;

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060005F2 RID: 1522
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060005F4 RID: 1524
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060005F6 RID: 1526
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060005F8 RID: 1528
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060005FA RID: 1530
		private delegate WrapMode get_wrapModeDelegate(IntPtr @this);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060005FC RID: 1532
		private delegate void set_wrapModeDelegate(IntPtr @this, WrapMode value);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060005FE RID: 1534
		private delegate float get_timeDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000600 RID: 1536
		private delegate void set_timeDelegate(IntPtr @this, float value);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x06000602 RID: 1538
		private delegate float get_normalizedTimeDelegate(IntPtr @this);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000604 RID: 1540
		private delegate void set_normalizedTimeDelegate(IntPtr @this, float value);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x06000606 RID: 1542
		private delegate float get_speedDelegate(IntPtr @this);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000608 RID: 1544
		private delegate void set_speedDelegate(IntPtr @this, float value);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x0600060A RID: 1546
		private delegate float get_normalizedSpeedDelegate(IntPtr @this);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x0600060C RID: 1548
		private delegate void set_normalizedSpeedDelegate(IntPtr @this, float value);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x0600060E RID: 1550
		private delegate float get_lengthDelegate(IntPtr @this);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x06000610 RID: 1552
		private delegate int get_layerDelegate(IntPtr @this);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x06000612 RID: 1554
		private delegate void set_layerDelegate(IntPtr @this, int value);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x06000614 RID: 1556
		private delegate IntPtr get_clipDelegate(IntPtr @this);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000616 RID: 1558
		private delegate IntPtr get_nameDelegate(IntPtr @this);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000618 RID: 1560
		private delegate void set_nameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x0600061A RID: 1562
		private delegate AnimationBlendMode get_blendModeDelegate(IntPtr @this);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x0600061C RID: 1564
		private delegate void set_blendModeDelegate(IntPtr @this, AnimationBlendMode value);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x0600061E RID: 1566
		private delegate void AddMixingTransformDelegate(IntPtr @this, IntPtr mix, bool recursive);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000620 RID: 1568
		private delegate void RemoveMixingTransformDelegate(IntPtr @this, IntPtr mix);
	}
}
