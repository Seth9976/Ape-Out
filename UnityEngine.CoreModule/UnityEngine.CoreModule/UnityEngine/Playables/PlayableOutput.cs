using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x0200018C RID: 396
	[StructLayout(2)]
	public struct PlayableOutput
	{
		// Token: 0x06001E5A RID: 7770 RVA: 0x0006F584 File Offset: 0x0006D784
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutput()
		{
			Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr);
			PlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, "m_Handle");
			PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, "m_NullPlayableOutput");
			PlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100666052);
			PlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100666053);
			PlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100666054);
			PlayableOutput.NativeMethodInfoPtr_IsPlayableOutputOfType_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100666055);
			PlayableOutput.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100666056);
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x0006F640 File Offset: 0x0006D840
		public unsafe static PlayableOutput Null
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504001, XrefRangeEnd = 504005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x0006F670 File Offset: 0x0006D870
		[CallerCount(0)]
		public unsafe PlayableOutput(PlayableOutputHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0006F6A4 File Offset: 0x0006D8A4
		[CallerCount(0)]
		public unsafe PlayableOutputHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0006F6D4 File Offset: 0x0006D8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504005, XrefRangeEnd = 504014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayableOutputOfType<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.MethodInfoStoreGeneric_IsPlayableOutputOfType_Public_Boolean_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x0006F704 File Offset: 0x0006D904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504014, XrefRangeEnd = 504021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableOutput other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x0000FF6B File Offset: 0x0000E16B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x0006F744 File Offset: 0x0006D944
		// (set) Token: 0x06001E62 RID: 7778 RVA: 0x0000FF7D File Offset: 0x0000E17D
		public unsafe static PlayableOutput m_NullPlayableOutput
		{
			get
			{
				PlayableOutput playableOutput;
				IL2CPP.il2cpp_field_static_get_value(PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput, (void*)(&playableOutput));
				return playableOutput;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput, (void*)(&value));
			}
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x0006F760 File Offset: 0x0006D960
		public Type GetPlayableOutputType()
		{
			return this.GetHandle().GetPlayableOutputType();
		}

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayableOutput;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutput_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayableOutputOfType_Public_Boolean_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0;

		// Token: 0x0400174D RID: 5965
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;

		// Token: 0x02000A33 RID: 2611
		private sealed class MethodInfoStoreGeneric_IsPlayableOutputOfType_Public_Boolean_0<T>
		{
			// Token: 0x04001FF6 RID: 8182
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutput.NativeMethodInfoPtr_IsPlayableOutputOfType_Public_Boolean_0, Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
