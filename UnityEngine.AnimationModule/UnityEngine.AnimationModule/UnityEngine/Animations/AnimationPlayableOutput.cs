using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000023 RID: 35
	[StructLayout(2)]
	public struct AnimationPlayableOutput
	{
		// Token: 0x060003A1 RID: 929 RVA: 0x0000C880 File Offset: 0x0000AA80
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPlayableOutput()
		{
			Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr);
			AnimationPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, "m_Handle");
			AnimationPlayableOutput.NativeMethodInfoPtr_Create_Public_Static_AnimationPlayableOutput_PlayableGraph_String_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100663433);
			AnimationPlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100663434);
			AnimationPlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100663435);
			AnimationPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100663436);
			AnimationPlayableOutput.NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100663437);
			AnimationPlayableOutput.NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationPlayableOutput_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100663438);
			AnimationPlayableOutput.NativeMethodInfoPtr_GetTarget_Public_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100663439);
			AnimationPlayableOutput.NativeMethodInfoPtr_SetTarget_Public_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100663440);
			AnimationPlayableOutput.NativeMethodInfoPtr_InternalGetTarget_Private_Static_Animator_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100663441);
			AnimationPlayableOutput.NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, 100663442);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000C98C File Offset: 0x0000AB8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484484, RefRangeEnd = 484485, XrefRangeStart = 484462, XrefRangeEnd = 484484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableOutput.NativeMethodInfoPtr_Create_Public_Static_AnimationPlayableOutput_PlayableGraph_String_Animator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484485, XrefRangeEnd = 484489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationPlayableOutput(PlayableOutputHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000CA24 File Offset: 0x0000AC24
		public unsafe static AnimationPlayableOutput Null
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 484514, RefRangeEnd = 484515, XrefRangeStart = 484489, XrefRangeEnd = 484514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationPlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000CA54 File Offset: 0x0000AC54
		[CallerCount(0)]
		public unsafe PlayableOutputHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000CA84 File Offset: 0x0000AC84
		[CallerCount(0)]
		public unsafe static implicit operator PlayableOutput(AnimationPlayableOutput output)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref output;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableOutput.NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AnimationPlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000CAC4 File Offset: 0x0000ACC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484531, RefRangeEnd = 484532, XrefRangeStart = 484515, XrefRangeEnd = 484531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator AnimationPlayableOutput(PlayableOutput output)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref output;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableOutput.NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationPlayableOutput_PlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000CB04 File Offset: 0x0000AD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484532, XrefRangeEnd = 484536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Animator GetTarget()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableOutput.NativeMethodInfoPtr_GetTarget_Public_Animator_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000CB38 File Offset: 0x0000AD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484536, XrefRangeEnd = 484540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(Animator value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableOutput.NativeMethodInfoPtr_SetTarget_Public_Void_Animator_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Animator InternalGetTarget(ref PlayableOutputHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableOutput.NativeMethodInfoPtr_InternalGetTarget_Private_Static_Animator_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000CBB0 File Offset: 0x0000ADB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableOutput.NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_Animator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00004219 File Offset: 0x00002419
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AnimationPlayableOutput_PlayableGraph_String_Animator_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationPlayableOutput_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AnimationPlayableOutput_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationPlayableOutput_PlayableOutput_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_GetTarget_Public_Animator_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_Animator_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetTarget_Private_Static_Animator_byref_PlayableOutputHandle_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_Animator_0;

		// Token: 0x0400022F RID: 559
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;
	}
}
