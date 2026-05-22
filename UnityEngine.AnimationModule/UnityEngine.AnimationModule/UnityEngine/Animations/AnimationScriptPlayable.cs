using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000026 RID: 38
	[StructLayout(2)]
	public struct AnimationScriptPlayable
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x0000D21C File Offset: 0x0000B41C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationScriptPlayable()
		{
			Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationScriptPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr);
			AnimationScriptPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, "m_Handle");
			AnimationScriptPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationScriptPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, 100663456);
			AnimationScriptPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, 100663457);
			AnimationScriptPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationScriptPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, 100663458);
			AnimationScriptPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationScriptPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationScriptPlayable::CreateHandleInternal_Injected");
			AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegate>("UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputsInternal_Injected");
			AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegate>("UnityEngine.Animations.AnimationScriptPlayable::GetProcessInputsInternal_Injected");
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484621, XrefRangeEnd = 484625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationScriptPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationScriptPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000D314 File Offset: 0x0000B514
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationScriptPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000D344 File Offset: 0x0000B544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484625, XrefRangeEnd = 484632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationScriptPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationScriptPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationScriptPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00004304 File Offset: 0x00002504
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000D384 File Offset: 0x0000B584
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00004316 File Offset: 0x00002516
		public unsafe static AnimationScriptPlayable m_NullPlayable
		{
			get
			{
				AnimationScriptPlayable animationScriptPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationScriptPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationScriptPlayable));
				return animationScriptPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationScriptPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000D3A0 File Offset: 0x0000B5A0
		public static AnimationScriptPlayable Null
		{
			get
			{
				return AnimationScriptPlayable.m_NullPlayable;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000D3B8 File Offset: 0x0000B5B8
		public static AnimationScriptPlayable Create<T>(PlayableGraph graph, T jobData, [Optional] int inputCount) where T : struct
		{
			PlayableHandle playableHandle = AnimationScriptPlayable.CreateHandle<T>(graph, inputCount);
			AnimationScriptPlayable animationScriptPlayable = new AnimationScriptPlayable(playableHandle);
			animationScriptPlayable.SetJobData<T>(jobData);
			return animationScriptPlayable;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00004324 File Offset: 0x00002524
		public static PlayableHandle CreateHandle<T>(PlayableGraph graph, int inputCount) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000D3E4 File Offset: 0x0000B5E4
		public void CheckJobTypeValidity<T>()
		{
			Type jobType = this.GetHandle().GetJobType();
			bool flag = jobType != Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			if (flag)
			{
				throw new ArgumentException(String.Format("Wrong type: the given job type ({0}) is different from the creation job type ({1}).", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).FullName, jobType.FullName));
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000D43C File Offset: 0x0000B63C
		public unsafe T GetJobData<T>() where T : struct
		{
			this.CheckJobTypeValidity<T>();
			T t;
			UnsafeUtility.CopyPtrToStructure<T>((void*)this.GetHandle().GetJobData(), out t);
			return t;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000D474 File Offset: 0x0000B674
		public unsafe void SetJobData<T>(T jobData) where T : struct
		{
			this.CheckJobTypeValidity<T>();
			UnsafeUtility.CopyStructureToPtr<T>(ref jobData, (void*)this.GetHandle().GetJobData());
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		public static implicit operator Playable(AnimationScriptPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		public static explicit operator AnimationScriptPlayable(Playable playable)
		{
			return new AnimationScriptPlayable(playable.GetHandle());
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00004331 File Offset: 0x00002531
		public void SetProcessInputs(bool value)
		{
			AnimationScriptPlayable.SetProcessInputsInternal(this.GetHandle(), value);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
		public bool GetProcessInputs()
		{
			return AnimationScriptPlayable.GetProcessInputsInternal(this.GetHandle());
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00004341 File Offset: 0x00002541
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData)
		{
			return AnimationScriptPlayable.CreateHandleInternal_Injected(ref graph, ref handle, jobReflectionData);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000434C File Offset: 0x0000254C
		public static void SetProcessInputsInternal(PlayableHandle handle, bool value)
		{
			AnimationScriptPlayable.SetProcessInputsInternal_Injected(ref handle, value);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00004356 File Offset: 0x00002556
		public static bool GetProcessInputsInternal(PlayableHandle handle)
		{
			return AnimationScriptPlayable.GetProcessInputsInternal_Injected(ref handle);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000435F File Offset: 0x0000255F
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData)
		{
			return AnimationScriptPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle, jobReflectionData);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000436E File Offset: 0x0000256E
		public static void SetProcessInputsInternal_Injected(ref PlayableHandle handle, bool value)
		{
			AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegateField(ref handle, value);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000437C File Offset: 0x0000257C
		public static bool GetProcessInputsInternal_Injected(ref PlayableHandle handle)
		{
			return AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegateField(ref handle);
		}

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationScriptPlayable_0;

		// Token: 0x0400024D RID: 589
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x0400024E RID: 590
		private static readonly AnimationScriptPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x0400024F RID: 591
		private static readonly AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegate SetProcessInputsInternal_InjectedDelegateField;

		// Token: 0x04000250 RID: 592
		private static readonly AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegate GetProcessInputsInternal_InjectedDelegateField;

		// Token: 0x02000195 RID: 405
		// (Invoke) Token: 0x06000820 RID: 2080
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle, IntPtr jobReflectionData);

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x06000822 RID: 2082
		private delegate void SetProcessInputsInternal_InjectedDelegate(IntPtr handle, bool value);

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x06000824 RID: 2084
		private delegate bool GetProcessInputsInternal_InjectedDelegate(IntPtr handle);
	}
}
