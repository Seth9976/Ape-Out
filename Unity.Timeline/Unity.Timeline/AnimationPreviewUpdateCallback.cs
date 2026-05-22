using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000007 RID: 7
	public class AnimationPreviewUpdateCallback : Object
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00005CD4 File Offset: 0x00003ED4
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPreviewUpdateCallback()
		{
			Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "AnimationPreviewUpdateCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr);
			AnimationPreviewUpdateCallback.NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, "m_Output");
			AnimationPreviewUpdateCallback.NativeFieldInfoPtr_m_Graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, "m_Graph");
			AnimationPreviewUpdateCallback.NativeFieldInfoPtr_m_PreviewComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, "m_PreviewComponents");
			AnimationPreviewUpdateCallback.NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, 100663363);
			AnimationPreviewUpdateCallback.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, 100663364);
			AnimationPreviewUpdateCallback.NativeMethodInfoPtr_FetchPreviewComponents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, 100663365);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005D7C File Offset: 0x00003F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472741, RefRangeEnd = 472742, XrefRangeStart = 472723, XrefRangeEnd = 472741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationPreviewUpdateCallback(AnimationPlayableOutput output)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref output;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPreviewUpdateCallback.NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005DC4 File Offset: 0x00003FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472742, XrefRangeEnd = 472757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPreviewUpdateCallback.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005DF8 File Offset: 0x00003FF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472784, RefRangeEnd = 472785, XrefRangeStart = 472757, XrefRangeEnd = 472784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FetchPreviewComponents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPreviewUpdateCallback.NativeMethodInfoPtr_FetchPreviewComponents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000229C File Offset: 0x0000049C
		public AnimationPreviewUpdateCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00005E2C File Offset: 0x0000402C
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000022A5 File Offset: 0x000004A5
		public unsafe AnimationPlayableOutput m_Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPreviewUpdateCallback.NativeFieldInfoPtr_m_Output);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPreviewUpdateCallback.NativeFieldInfoPtr_m_Output)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00005E54 File Offset: 0x00004054
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000022C0 File Offset: 0x000004C0
		public unsafe PlayableGraph m_Graph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPreviewUpdateCallback.NativeFieldInfoPtr_m_Graph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPreviewUpdateCallback.NativeFieldInfoPtr_m_Graph)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00005E7C File Offset: 0x0000407C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000022DB File Offset: 0x000004DB
		public unsafe List<IAnimationWindowPreview> m_PreviewComponents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPreviewUpdateCallback.NativeFieldInfoPtr_m_PreviewComponents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAnimationWindowPreview>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPreviewUpdateCallback.NativeFieldInfoPtr_m_PreviewComponents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_m_Output;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_m_Graph;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviewComponents;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_FetchPreviewComponents_Private_Void_0;
	}
}
