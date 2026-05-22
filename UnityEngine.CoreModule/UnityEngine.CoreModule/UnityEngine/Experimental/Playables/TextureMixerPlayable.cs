using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020001A4 RID: 420
	[StructLayout(2)]
	public struct TextureMixerPlayable
	{
		// Token: 0x06001F2A RID: 7978 RVA: 0x00072AC8 File Offset: 0x00070CC8
		// Note: this type is marked as 'beforefieldinit'.
		static TextureMixerPlayable()
		{
			Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "TextureMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr);
			TextureMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, "m_Handle");
			TextureMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100666156);
			TextureMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100666157);
			TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegateField = IL2CPP.ResolveICall<TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegate>("UnityEngine.Experimental.Playables.TextureMixerPlayable::CreateTextureMixerPlayableInternal");
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00072B44 File Offset: 0x00070D44
		[CallerCount(0)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00072B74 File Offset: 0x00070D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504710, XrefRangeEnd = 504717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TextureMixerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00010287 File Offset: 0x0000E487
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00072BB4 File Offset: 0x00070DB4
		public static TextureMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = TextureMixerPlayable.CreateHandle(graph);
			return new TextureMixerPlayable(playableHandle);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00072BD4 File Offset: 0x00070DD4
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !TextureMixerPlayable.CreateTextureMixerPlayableInternal(ref graph, ref @null);
			UnityEngine.Playables.PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00072C08 File Offset: 0x00070E08
		public static implicit operator UnityEngine.Playables.Playable(TextureMixerPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00072C28 File Offset: 0x00070E28
		public static explicit operator TextureMixerPlayable(UnityEngine.Playables.Playable playable)
		{
			return new TextureMixerPlayable(playable.GetHandle());
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00010299 File Offset: 0x0000E499
		public static bool CreateTextureMixerPlayableInternal(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegateField(ref graph, ref handle);
		}

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0;

		// Token: 0x04001896 RID: 6294
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x04001897 RID: 6295
		private static readonly TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegate CreateTextureMixerPlayableInternalDelegateField;

		// Token: 0x02000A52 RID: 2642
		// (Invoke) Token: 0x06003324 RID: 13092
		private delegate bool CreateTextureMixerPlayableInternalDelegate(IntPtr graph, IntPtr handle);
	}
}
