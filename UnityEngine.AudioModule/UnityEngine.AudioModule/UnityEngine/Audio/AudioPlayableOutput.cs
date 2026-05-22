using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000015 RID: 21
	[StructLayout(2)]
	public struct AudioPlayableOutput
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00006EC4 File Offset: 0x000050C4
		// Note: this type is marked as 'beforefieldinit'.
		static AudioPlayableOutput()
		{
			Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioPlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr);
			AudioPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, "m_Handle");
			AudioPlayableOutput.NativeMethodInfoPtr_Create_Public_Static_AudioPlayableOutput_PlayableGraph_String_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663441);
			AudioPlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663442);
			AudioPlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_AudioPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663443);
			AudioPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663444);
			AudioPlayableOutput.NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AudioPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663445);
			AudioPlayableOutput.NativeMethodInfoPtr_op_Explicit_Public_Static_AudioPlayableOutput_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663446);
			AudioPlayableOutput.NativeMethodInfoPtr_SetTarget_Public_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663447);
			AudioPlayableOutput.NativeMethodInfoPtr_SetEvaluateOnSeek_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663448);
			AudioPlayableOutput.NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663449);
			AudioPlayableOutput.NativeMethodInfoPtr_InternalSetEvaluateOnSeek_Private_Static_Void_byref_PlayableOutputHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663450);
			AudioPlayableOutput.InternalGetTargetDelegateField = IL2CPP.ResolveICall<AudioPlayableOutput.InternalGetTargetDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalGetTarget");
			AudioPlayableOutput.InternalGetEvaluateOnSeekDelegateField = IL2CPP.ResolveICall<AudioPlayableOutput.InternalGetEvaluateOnSeekDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalGetEvaluateOnSeek");
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006FF0 File Offset: 0x000051F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485622, RefRangeEnd = 485623, XrefRangeStart = 485600, XrefRangeEnd = 485622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableOutput.NativeMethodInfoPtr_Create_Public_Static_AudioPlayableOutput_PlayableGraph_String_AudioSource_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00007054 File Offset: 0x00005254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485623, XrefRangeEnd = 485627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioPlayableOutput(PlayableOutputHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00007088 File Offset: 0x00005288
		public unsafe static AudioPlayableOutput Null
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 485652, RefRangeEnd = 485653, XrefRangeStart = 485627, XrefRangeEnd = 485652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_AudioPlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000070B8 File Offset: 0x000052B8
		[CallerCount(0)]
		public unsafe PlayableOutputHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000070E8 File Offset: 0x000052E8
		[CallerCount(0)]
		public unsafe static implicit operator PlayableOutput(AudioPlayableOutput output)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref output;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableOutput.NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AudioPlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00007128 File Offset: 0x00005328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 485669, RefRangeEnd = 485670, XrefRangeStart = 485653, XrefRangeEnd = 485669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator AudioPlayableOutput(PlayableOutput output)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref output;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableOutput.NativeMethodInfoPtr_op_Explicit_Public_Static_AudioPlayableOutput_PlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00007168 File Offset: 0x00005368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485670, XrefRangeEnd = 485674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(AudioSource value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableOutput.NativeMethodInfoPtr_SetTarget_Public_Void_AudioSource_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000071A0 File Offset: 0x000053A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485674, XrefRangeEnd = 485678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEvaluateOnSeek(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableOutput.NativeMethodInfoPtr_SetEvaluateOnSeek_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000071D4 File Offset: 0x000053D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &output;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableOutput.NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_AudioSource_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00007218 File Offset: 0x00005418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &output;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPlayableOutput.NativeMethodInfoPtr_InternalSetEvaluateOnSeek_Private_Static_Void_byref_PlayableOutputHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000028C1 File Offset: 0x00000AC1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00007258 File Offset: 0x00005458
		public AudioSource GetTarget()
		{
			return AudioPlayableOutput.InternalGetTarget(ref this.m_Handle);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00007278 File Offset: 0x00005478
		public bool GetEvaluateOnSeek()
		{
			return AudioPlayableOutput.InternalGetEvaluateOnSeek(ref this.m_Handle);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00007298 File Offset: 0x00005498
		public static AudioSource InternalGetTarget(ref PlayableOutputHandle output)
		{
			IntPtr intPtr = AudioPlayableOutput.InternalGetTargetDelegateField(ref output);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000028D3 File Offset: 0x00000AD3
		public static bool InternalGetEvaluateOnSeek(ref PlayableOutputHandle output)
		{
			return AudioPlayableOutput.InternalGetEvaluateOnSeekDelegateField(ref output);
		}

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AudioPlayableOutput_PlayableGraph_String_AudioSource_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_AudioPlayableOutput_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AudioPlayableOutput_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AudioPlayableOutput_PlayableOutput_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_AudioSource_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_SetEvaluateOnSeek_Public_Void_Boolean_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_AudioSource_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetEvaluateOnSeek_Private_Static_Void_byref_PlayableOutputHandle_Boolean_0;

		// Token: 0x0400011F RID: 287
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;

		// Token: 0x04000120 RID: 288
		private static readonly AudioPlayableOutput.InternalGetTargetDelegate InternalGetTargetDelegateField;

		// Token: 0x04000121 RID: 289
		private static readonly AudioPlayableOutput.InternalGetEvaluateOnSeekDelegate InternalGetEvaluateOnSeekDelegateField;

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060002D0 RID: 720
		private delegate IntPtr InternalGetTargetDelegate(IntPtr output);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060002D2 RID: 722
		private delegate bool InternalGetEvaluateOnSeekDelegate(IntPtr output);
	}
}
