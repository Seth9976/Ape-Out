using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000024 RID: 36
	[StructLayout(2)]
	public struct AnimationPosePlayable
	{
		// Token: 0x060003AD RID: 941 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPosePlayable()
		{
			Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPosePlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr);
			AnimationPosePlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, "m_Handle");
			AnimationPosePlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationPosePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, 100663443);
			AnimationPosePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, 100663444);
			AnimationPosePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationPosePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, 100663445);
			AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::GetMustReadPreviousPoseInternal");
			AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::SetMustReadPreviousPoseInternal");
			AnimationPosePlayable.GetReadDefaultPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.GetReadDefaultPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::GetReadDefaultPoseInternal");
			AnimationPosePlayable.SetReadDefaultPoseInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.SetReadDefaultPoseInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::SetReadDefaultPoseInternal");
			AnimationPosePlayable.GetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.GetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::GetApplyFootIKInternal");
			AnimationPosePlayable.SetApplyFootIKInternalDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.SetApplyFootIKInternalDelegate>("UnityEngine.Animations.AnimationPosePlayable::SetApplyFootIKInternal");
			AnimationPosePlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPosePlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationPosePlayable::CreateHandleInternal_Injected");
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484540, XrefRangeEnd = 484544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationPosePlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPosePlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000CD28 File Offset: 0x0000AF28
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPosePlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000CD58 File Offset: 0x0000AF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484544, XrefRangeEnd = 484550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationPosePlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPosePlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationPosePlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000422B File Offset: 0x0000242B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationPosePlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000CD98 File Offset: 0x0000AF98
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0000423D File Offset: 0x0000243D
		public unsafe static AnimationPosePlayable m_NullPlayable
		{
			get
			{
				AnimationPosePlayable animationPosePlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationPosePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationPosePlayable));
				return animationPosePlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationPosePlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000CDB4 File Offset: 0x0000AFB4
		public static AnimationPosePlayable Null
		{
			get
			{
				return AnimationPosePlayable.m_NullPlayable;
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000CDCC File Offset: 0x0000AFCC
		public static AnimationPosePlayable Create(PlayableGraph graph)
		{
			PlayableHandle playableHandle = AnimationPosePlayable.CreateHandle(graph);
			return new AnimationPosePlayable(playableHandle);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		public static PlayableHandle CreateHandle(PlayableGraph graph)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimationPosePlayable.CreateHandleInternal(graph, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000CE1C File Offset: 0x0000B01C
		public static implicit operator Playable(AnimationPosePlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000CE3C File Offset: 0x0000B03C
		public static explicit operator AnimationPosePlayable(Playable playable)
		{
			return new AnimationPosePlayable(playable.GetHandle());
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000CE5C File Offset: 0x0000B05C
		public bool GetMustReadPreviousPose()
		{
			return AnimationPosePlayable.GetMustReadPreviousPoseInternal(ref this.m_Handle);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000424B File Offset: 0x0000244B
		public void SetMustReadPreviousPose(bool value)
		{
			AnimationPosePlayable.SetMustReadPreviousPoseInternal(ref this.m_Handle, value);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public bool GetReadDefaultPose()
		{
			return AnimationPosePlayable.GetReadDefaultPoseInternal(ref this.m_Handle);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000425B File Offset: 0x0000245B
		public void SetReadDefaultPose(bool value)
		{
			AnimationPosePlayable.SetReadDefaultPoseInternal(ref this.m_Handle, value);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000CE9C File Offset: 0x0000B09C
		public bool GetApplyFootIK()
		{
			return AnimationPosePlayable.GetApplyFootIKInternal(ref this.m_Handle);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000426B File Offset: 0x0000246B
		public void SetApplyFootIK(bool value)
		{
			AnimationPosePlayable.SetApplyFootIKInternal(ref this.m_Handle, value);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000427B File Offset: 0x0000247B
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationPosePlayable.CreateHandleInternal_Injected(ref graph, ref handle);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00004285 File Offset: 0x00002485
		public static bool GetMustReadPreviousPoseInternal(ref PlayableHandle handle)
		{
			return AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegateField(ref handle);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00004292 File Offset: 0x00002492
		public static void SetMustReadPreviousPoseInternal(ref PlayableHandle handle, bool value)
		{
			AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegateField(ref handle, value);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000042A0 File Offset: 0x000024A0
		public static bool GetReadDefaultPoseInternal(ref PlayableHandle handle)
		{
			return AnimationPosePlayable.GetReadDefaultPoseInternalDelegateField(ref handle);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000042AD File Offset: 0x000024AD
		public static void SetReadDefaultPoseInternal(ref PlayableHandle handle, bool value)
		{
			AnimationPosePlayable.SetReadDefaultPoseInternalDelegateField(ref handle, value);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000042BB File Offset: 0x000024BB
		public static bool GetApplyFootIKInternal(ref PlayableHandle handle)
		{
			return AnimationPosePlayable.GetApplyFootIKInternalDelegateField(ref handle);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000042C8 File Offset: 0x000024C8
		public static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value)
		{
			AnimationPosePlayable.SetApplyFootIKInternalDelegateField(ref handle, value);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000042D6 File Offset: 0x000024D6
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return AnimationPosePlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle);
		}

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationPosePlayable_0;

		// Token: 0x04000235 RID: 565
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x04000236 RID: 566
		private static readonly AnimationPosePlayable.GetMustReadPreviousPoseInternalDelegate GetMustReadPreviousPoseInternalDelegateField;

		// Token: 0x04000237 RID: 567
		private static readonly AnimationPosePlayable.SetMustReadPreviousPoseInternalDelegate SetMustReadPreviousPoseInternalDelegateField;

		// Token: 0x04000238 RID: 568
		private static readonly AnimationPosePlayable.GetReadDefaultPoseInternalDelegate GetReadDefaultPoseInternalDelegateField;

		// Token: 0x04000239 RID: 569
		private static readonly AnimationPosePlayable.SetReadDefaultPoseInternalDelegate SetReadDefaultPoseInternalDelegateField;

		// Token: 0x0400023A RID: 570
		private static readonly AnimationPosePlayable.GetApplyFootIKInternalDelegate GetApplyFootIKInternalDelegateField;

		// Token: 0x0400023B RID: 571
		private static readonly AnimationPosePlayable.SetApplyFootIKInternalDelegate SetApplyFootIKInternalDelegateField;

		// Token: 0x0400023C RID: 572
		private static readonly AnimationPosePlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x0200018E RID: 398
		// (Invoke) Token: 0x06000812 RID: 2066
		private delegate bool GetMustReadPreviousPoseInternalDelegate(IntPtr handle);

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x06000814 RID: 2068
		private delegate void SetMustReadPreviousPoseInternalDelegate(IntPtr handle, bool value);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x06000816 RID: 2070
		private delegate bool GetReadDefaultPoseInternalDelegate(IntPtr handle);

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x06000818 RID: 2072
		private delegate void SetReadDefaultPoseInternalDelegate(IntPtr handle, bool value);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x0600081A RID: 2074
		private delegate bool GetApplyFootIKInternalDelegate(IntPtr handle);

		// Token: 0x02000193 RID: 403
		// (Invoke) Token: 0x0600081C RID: 2076
		private delegate void SetApplyFootIKInternalDelegate(IntPtr handle, bool value);

		// Token: 0x02000194 RID: 404
		// (Invoke) Token: 0x0600081E RID: 2078
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle);
	}
}
