using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public sealed class AnimationClip : Motion
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00006D4C File Offset: 0x00004F4C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationClip()
		{
			Il2CppClassPointerStore<AnimationClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimationClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr);
			AnimationClip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663321);
			AnimationClip.NativeMethodInfoPtr_Internal_CreateAnimationClip_Private_Static_Void_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663322);
			AnimationClip.NativeMethodInfoPtr_get_length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663323);
			AnimationClip.NativeMethodInfoPtr_get_frameRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663324);
			AnimationClip.NativeMethodInfoPtr_set_frameRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663325);
			AnimationClip.NativeMethodInfoPtr_get_legacy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663326);
			AnimationClip.NativeMethodInfoPtr_set_legacy_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663327);
			AnimationClip.NativeMethodInfoPtr_get_empty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663328);
			AnimationClip.NativeMethodInfoPtr_get_hasGenericRootTransform_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663329);
			AnimationClip.NativeMethodInfoPtr_get_hasMotionCurves_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663330);
			AnimationClip.NativeMethodInfoPtr_get_hasRootCurves_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663331);
			AnimationClip.NativeMethodInfoPtr_get_hasRootMotion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr, 100663332);
			AnimationClip.SampleAnimationDelegateField = IL2CPP.ResolveICall<AnimationClip.SampleAnimationDelegate>("UnityEngine.AnimationClip::SampleAnimation");
			AnimationClip.get_startTimeDelegateField = IL2CPP.ResolveICall<AnimationClip.get_startTimeDelegate>("UnityEngine.AnimationClip::get_startTime");
			AnimationClip.get_stopTimeDelegateField = IL2CPP.ResolveICall<AnimationClip.get_stopTimeDelegate>("UnityEngine.AnimationClip::get_stopTime");
			AnimationClip.SetCurveDelegateField = IL2CPP.ResolveICall<AnimationClip.SetCurveDelegate>("UnityEngine.AnimationClip::SetCurve");
			AnimationClip.EnsureQuaternionContinuityDelegateField = IL2CPP.ResolveICall<AnimationClip.EnsureQuaternionContinuityDelegate>("UnityEngine.AnimationClip::EnsureQuaternionContinuity");
			AnimationClip.ClearCurvesDelegateField = IL2CPP.ResolveICall<AnimationClip.ClearCurvesDelegate>("UnityEngine.AnimationClip::ClearCurves");
			AnimationClip.get_wrapModeDelegateField = IL2CPP.ResolveICall<AnimationClip.get_wrapModeDelegate>("UnityEngine.AnimationClip::get_wrapMode");
			AnimationClip.set_wrapModeDelegateField = IL2CPP.ResolveICall<AnimationClip.set_wrapModeDelegate>("UnityEngine.AnimationClip::set_wrapMode");
			AnimationClip.get_humanMotionDelegateField = IL2CPP.ResolveICall<AnimationClip.get_humanMotionDelegate>("UnityEngine.AnimationClip::get_humanMotion");
			AnimationClip.get_hasMotionFloatCurvesDelegateField = IL2CPP.ResolveICall<AnimationClip.get_hasMotionFloatCurvesDelegate>("UnityEngine.AnimationClip::get_hasMotionFloatCurves");
			AnimationClip.AddEventInternalDelegateField = IL2CPP.ResolveICall<AnimationClip.AddEventInternalDelegate>("UnityEngine.AnimationClip::AddEventInternal");
			AnimationClip.SetEventsInternalDelegateField = IL2CPP.ResolveICall<AnimationClip.SetEventsInternalDelegate>("UnityEngine.AnimationClip::SetEventsInternal");
			AnimationClip.GetEventsInternalDelegateField = IL2CPP.ResolveICall<AnimationClip.GetEventsInternalDelegate>("UnityEngine.AnimationClip::GetEventsInternal");
			AnimationClip.get_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<AnimationClip.get_localBounds_InjectedDelegate>("UnityEngine.AnimationClip::get_localBounds_Injected");
			AnimationClip.set_localBounds_InjectedDelegateField = IL2CPP.ResolveICall<AnimationClip.set_localBounds_InjectedDelegate>("UnityEngine.AnimationClip::set_localBounds_Injected");
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006F50 File Offset: 0x00005150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483757, XrefRangeEnd = 483764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationClip()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationClip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00006F8C File Offset: 0x0000518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483764, XrefRangeEnd = 483768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateAnimationClip(AnimationClip self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_Internal_CreateAnimationClip_Private_Static_Void_AnimationClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00006FC4 File Offset: 0x000051C4
		public unsafe float length
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483772, RefRangeEnd = 483773, XrefRangeStart = 483768, XrefRangeEnd = 483772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_get_length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00007000 File Offset: 0x00005200
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000703C File Offset: 0x0000523C
		public unsafe float frameRate
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 483777, RefRangeEnd = 483779, XrefRangeStart = 483773, XrefRangeEnd = 483777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_get_frameRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483779, XrefRangeEnd = 483783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_set_frameRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000707C File Offset: 0x0000527C
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000070B8 File Offset: 0x000052B8
		public new unsafe bool legacy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483783, XrefRangeEnd = 483787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_get_legacy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483787, XrefRangeEnd = 483791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_set_legacy_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000070F8 File Offset: 0x000052F8
		public unsafe bool empty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483791, XrefRangeEnd = 483795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_get_empty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00007134 File Offset: 0x00005334
		public unsafe bool hasGenericRootTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483795, XrefRangeEnd = 483799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_get_hasGenericRootTransform_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00007170 File Offset: 0x00005370
		public unsafe bool hasMotionCurves
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483799, XrefRangeEnd = 483803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_get_hasMotionCurves_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000071AC File Offset: 0x000053AC
		public unsafe bool hasRootCurves
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483803, XrefRangeEnd = 483807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_get_hasRootCurves_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000071E8 File Offset: 0x000053E8
		public unsafe bool hasRootMotion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483807, XrefRangeEnd = 483811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationClip.NativeMethodInfoPtr_get_hasRootMotion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000026CD File Offset: 0x000008CD
		public AnimationClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000026D6 File Offset: 0x000008D6
		public void SampleAnimation(GameObject go, float time)
		{
			AnimationClip.SampleAnimation(go, this, time, this.wrapMode);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000026E8 File Offset: 0x000008E8
		public static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode)
		{
			AnimationClip.SampleAnimationDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), IL2CPP.Il2CppObjectBaseToPtr(clip), inTime, wrapMode);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002702 File Offset: 0x00000902
		public float startTime
		{
			get
			{
				return AnimationClip.get_startTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002714 File Offset: 0x00000914
		public float stopTime
		{
			get
			{
				return AnimationClip.get_stopTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002726 File Offset: 0x00000926
		public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve)
		{
			AnimationClip.SetCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(relativePath), IL2CPP.Il2CppObjectBaseToPtr(type), IL2CPP.ManagedStringToIl2Cpp(propertyName), IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002751 File Offset: 0x00000951
		public void EnsureQuaternionContinuity()
		{
			AnimationClip.EnsureQuaternionContinuityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002763 File Offset: 0x00000963
		public void ClearCurves()
		{
			AnimationClip.ClearCurvesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002775 File Offset: 0x00000975
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002787 File Offset: 0x00000987
		public WrapMode wrapMode
		{
			get
			{
				return AnimationClip.get_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AnimationClip.set_wrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00007224 File Offset: 0x00005424
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000279A File Offset: 0x0000099A
		public Bounds localBounds
		{
			get
			{
				Bounds bounds;
				this.get_localBounds_Injected(out bounds);
				return bounds;
			}
			set
			{
				this.set_localBounds_Injected(ref value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000027A4 File Offset: 0x000009A4
		public bool humanMotion
		{
			get
			{
				return AnimationClip.get_humanMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000027B6 File Offset: 0x000009B6
		public bool hasMotionFloatCurves
		{
			get
			{
				return AnimationClip.get_hasMotionFloatCurvesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000723C File Offset: 0x0000543C
		public void AddEvent(AnimationEvent evt)
		{
			bool flag = evt == null;
			if (flag)
			{
				throw new ArgumentNullException("evt");
			}
			this.AddEventInternal(evt);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000027C8 File Offset: 0x000009C8
		public void AddEventInternal(Object evt)
		{
			AnimationClip.AddEventInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(evt));
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00007268 File Offset: 0x00005468
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000027E0 File Offset: 0x000009E0
		public Il2CppReferenceArray<AnimationEvent> events
		{
			get
			{
				return this.GetEventsInternal().Cast<Il2CppReferenceArray<AnimationEvent>>();
			}
			set
			{
				this.SetEventsInternal(value);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000027EB File Offset: 0x000009EB
		public void SetEventsInternal(Array value)
		{
			AnimationClip.SetEventsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00007288 File Offset: 0x00005488
		public Array GetEventsInternal()
		{
			IntPtr intPtr = AnimationClip.GetEventsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002803 File Offset: 0x00000A03
		public void get_localBounds_Injected(out Bounds ret)
		{
			AnimationClip.get_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002816 File Offset: 0x00000A16
		public void set_localBounds_Injected(ref Bounds value)
		{
			AnimationClip.set_localBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateAnimationClip_Private_Static_Void_AnimationClip_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Single_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_frameRate_Public_get_Single_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_set_frameRate_Public_set_Void_Single_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_legacy_Public_get_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_set_legacy_Public_set_Void_Boolean_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_empty_Public_get_Boolean_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_get_hasGenericRootTransform_Public_get_Boolean_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_hasMotionCurves_Public_get_Boolean_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_get_hasRootCurves_Public_get_Boolean_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_get_hasRootMotion_Internal_get_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly AnimationClip.SampleAnimationDelegate SampleAnimationDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly AnimationClip.get_startTimeDelegate get_startTimeDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly AnimationClip.get_stopTimeDelegate get_stopTimeDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly AnimationClip.SetCurveDelegate SetCurveDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly AnimationClip.EnsureQuaternionContinuityDelegate EnsureQuaternionContinuityDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly AnimationClip.ClearCurvesDelegate ClearCurvesDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly AnimationClip.get_wrapModeDelegate get_wrapModeDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly AnimationClip.set_wrapModeDelegate set_wrapModeDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly AnimationClip.get_humanMotionDelegate get_humanMotionDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly AnimationClip.get_hasMotionFloatCurvesDelegate get_hasMotionFloatCurvesDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly AnimationClip.AddEventInternalDelegate AddEventInternalDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly AnimationClip.SetEventsInternalDelegate SetEventsInternalDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly AnimationClip.GetEventsInternalDelegate GetEventsInternalDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly AnimationClip.get_localBounds_InjectedDelegate get_localBounds_InjectedDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly AnimationClip.set_localBounds_InjectedDelegate set_localBounds_InjectedDelegateField;

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x06000622 RID: 1570
		private delegate void SampleAnimationDelegate(IntPtr go, IntPtr clip, float inTime, WrapMode wrapMode);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000624 RID: 1572
		private delegate float get_startTimeDelegate(IntPtr @this);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000626 RID: 1574
		private delegate float get_stopTimeDelegate(IntPtr @this);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000628 RID: 1576
		private delegate void SetCurveDelegate(IntPtr @this, IntPtr relativePath, IntPtr type, IntPtr propertyName, IntPtr curve);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x0600062A RID: 1578
		private delegate void EnsureQuaternionContinuityDelegate(IntPtr @this);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x0600062C RID: 1580
		private delegate void ClearCurvesDelegate(IntPtr @this);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x0600062E RID: 1582
		private delegate WrapMode get_wrapModeDelegate(IntPtr @this);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000630 RID: 1584
		private delegate void set_wrapModeDelegate(IntPtr @this, WrapMode value);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x06000632 RID: 1586
		private delegate bool get_humanMotionDelegate(IntPtr @this);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x06000634 RID: 1588
		private delegate bool get_hasMotionFloatCurvesDelegate(IntPtr @this);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x06000636 RID: 1590
		private delegate void AddEventInternalDelegate(IntPtr @this, IntPtr evt);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000638 RID: 1592
		private delegate void SetEventsInternalDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x0600063A RID: 1594
		private delegate IntPtr GetEventsInternalDelegate(IntPtr @this);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x0600063C RID: 1596
		private delegate void get_localBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x0600063E RID: 1598
		private delegate void set_localBounds_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
