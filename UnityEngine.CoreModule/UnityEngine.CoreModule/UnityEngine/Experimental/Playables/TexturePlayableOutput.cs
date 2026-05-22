using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020001A5 RID: 421
	[StructLayout(2)]
	public struct TexturePlayableOutput
	{
		// Token: 0x06001F33 RID: 7987 RVA: 0x00072C48 File Offset: 0x00070E48
		// Note: this type is marked as 'beforefieldinit'.
		static TexturePlayableOutput()
		{
			Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "TexturePlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr);
			TexturePlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, "m_Handle");
			TexturePlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, 100666158);
			TexturePlayableOutput.InternalGetTargetDelegateField = IL2CPP.ResolveICall<TexturePlayableOutput.InternalGetTargetDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalGetTarget");
			TexturePlayableOutput.InternalSetTargetDelegateField = IL2CPP.ResolveICall<TexturePlayableOutput.InternalSetTargetDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalSetTarget");
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00072CC0 File Offset: 0x00070EC0
		[CallerCount(0)]
		public unsafe UnityEngine.Playables.PlayableOutputHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TexturePlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x000102A7 File Offset: 0x0000E4A7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00072CF0 File Offset: 0x00070EF0
		public static TexturePlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, RenderTexture target)
		{
			UnityEngine.Playables.PlayableOutputHandle playableOutputHandle;
			bool flag = !TexturePlayableGraphExtensions.InternalCreateTextureOutput(ref graph, name, out playableOutputHandle);
			TexturePlayableOutput texturePlayableOutput;
			if (flag)
			{
				texturePlayableOutput = TexturePlayableOutput.Null;
			}
			else
			{
				TexturePlayableOutput texturePlayableOutput2 = new TexturePlayableOutput(playableOutputHandle);
				texturePlayableOutput2.SetTarget(target);
				texturePlayableOutput = texturePlayableOutput2;
			}
			return texturePlayableOutput;
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x00072D30 File Offset: 0x00070F30
		public static TexturePlayableOutput Null
		{
			get
			{
				return new TexturePlayableOutput(UnityEngine.Playables.PlayableOutputHandle.Null);
			}
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00072D4C File Offset: 0x00070F4C
		public static implicit operator UnityEngine.Playables.PlayableOutput(TexturePlayableOutput output)
		{
			return new UnityEngine.Playables.PlayableOutput(output.GetHandle());
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00072D6C File Offset: 0x00070F6C
		public static explicit operator TexturePlayableOutput(UnityEngine.Playables.PlayableOutput output)
		{
			return new TexturePlayableOutput(output.GetHandle());
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00072D8C File Offset: 0x00070F8C
		public RenderTexture GetTarget()
		{
			return TexturePlayableOutput.InternalGetTarget(ref this.m_Handle);
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x000102B9 File Offset: 0x0000E4B9
		public void SetTarget(RenderTexture value)
		{
			TexturePlayableOutput.InternalSetTarget(ref this.m_Handle, value);
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00072DAC File Offset: 0x00070FAC
		public static RenderTexture InternalGetTarget(ref UnityEngine.Playables.PlayableOutputHandle output)
		{
			IntPtr intPtr = TexturePlayableOutput.InternalGetTargetDelegateField(ref output);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x000102C9 File Offset: 0x0000E4C9
		public static void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle output, RenderTexture target)
		{
			TexturePlayableOutput.InternalSetTargetDelegateField(ref output, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

		// Token: 0x0400189A RID: 6298
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableOutputHandle m_Handle;

		// Token: 0x0400189B RID: 6299
		private static readonly TexturePlayableOutput.InternalGetTargetDelegate InternalGetTargetDelegateField;

		// Token: 0x0400189C RID: 6300
		private static readonly TexturePlayableOutput.InternalSetTargetDelegate InternalSetTargetDelegateField;

		// Token: 0x02000A53 RID: 2643
		// (Invoke) Token: 0x06003326 RID: 13094
		private delegate IntPtr InternalGetTargetDelegate(IntPtr output);

		// Token: 0x02000A54 RID: 2644
		// (Invoke) Token: 0x06003328 RID: 13096
		private delegate void InternalSetTargetDelegate(IntPtr output, IntPtr target);
	}
}
