using System;

namespace UnityEngine
{
	// Token: 0x0200009C RID: 156
	public enum KeyCode
	{
		// Token: 0x04000AB6 RID: 2742
		None,
		// Token: 0x04000AB7 RID: 2743
		Backspace = 8,
		// Token: 0x04000AB8 RID: 2744
		Delete = 127,
		// Token: 0x04000AB9 RID: 2745
		Tab = 9,
		// Token: 0x04000ABA RID: 2746
		Clear = 12,
		// Token: 0x04000ABB RID: 2747
		Return,
		// Token: 0x04000ABC RID: 2748
		Pause = 19,
		// Token: 0x04000ABD RID: 2749
		Escape = 27,
		// Token: 0x04000ABE RID: 2750
		Space = 32,
		// Token: 0x04000ABF RID: 2751
		Keypad0 = 256,
		// Token: 0x04000AC0 RID: 2752
		Keypad1,
		// Token: 0x04000AC1 RID: 2753
		Keypad2,
		// Token: 0x04000AC2 RID: 2754
		Keypad3,
		// Token: 0x04000AC3 RID: 2755
		Keypad4,
		// Token: 0x04000AC4 RID: 2756
		Keypad5,
		// Token: 0x04000AC5 RID: 2757
		Keypad6,
		// Token: 0x04000AC6 RID: 2758
		Keypad7,
		// Token: 0x04000AC7 RID: 2759
		Keypad8,
		// Token: 0x04000AC8 RID: 2760
		Keypad9,
		// Token: 0x04000AC9 RID: 2761
		KeypadPeriod,
		// Token: 0x04000ACA RID: 2762
		KeypadDivide,
		// Token: 0x04000ACB RID: 2763
		KeypadMultiply,
		// Token: 0x04000ACC RID: 2764
		KeypadMinus,
		// Token: 0x04000ACD RID: 2765
		KeypadPlus,
		// Token: 0x04000ACE RID: 2766
		KeypadEnter,
		// Token: 0x04000ACF RID: 2767
		KeypadEquals,
		// Token: 0x04000AD0 RID: 2768
		UpArrow,
		// Token: 0x04000AD1 RID: 2769
		DownArrow,
		// Token: 0x04000AD2 RID: 2770
		RightArrow,
		// Token: 0x04000AD3 RID: 2771
		LeftArrow,
		// Token: 0x04000AD4 RID: 2772
		Insert,
		// Token: 0x04000AD5 RID: 2773
		Home,
		// Token: 0x04000AD6 RID: 2774
		End,
		// Token: 0x04000AD7 RID: 2775
		PageUp,
		// Token: 0x04000AD8 RID: 2776
		PageDown,
		// Token: 0x04000AD9 RID: 2777
		F1,
		// Token: 0x04000ADA RID: 2778
		F2,
		// Token: 0x04000ADB RID: 2779
		F3,
		// Token: 0x04000ADC RID: 2780
		F4,
		// Token: 0x04000ADD RID: 2781
		F5,
		// Token: 0x04000ADE RID: 2782
		F6,
		// Token: 0x04000ADF RID: 2783
		F7,
		// Token: 0x04000AE0 RID: 2784
		F8,
		// Token: 0x04000AE1 RID: 2785
		F9,
		// Token: 0x04000AE2 RID: 2786
		F10,
		// Token: 0x04000AE3 RID: 2787
		F11,
		// Token: 0x04000AE4 RID: 2788
		F12,
		// Token: 0x04000AE5 RID: 2789
		F13,
		// Token: 0x04000AE6 RID: 2790
		F14,
		// Token: 0x04000AE7 RID: 2791
		F15,
		// Token: 0x04000AE8 RID: 2792
		Alpha0 = 48,
		// Token: 0x04000AE9 RID: 2793
		Alpha1,
		// Token: 0x04000AEA RID: 2794
		Alpha2,
		// Token: 0x04000AEB RID: 2795
		Alpha3,
		// Token: 0x04000AEC RID: 2796
		Alpha4,
		// Token: 0x04000AED RID: 2797
		Alpha5,
		// Token: 0x04000AEE RID: 2798
		Alpha6,
		// Token: 0x04000AEF RID: 2799
		Alpha7,
		// Token: 0x04000AF0 RID: 2800
		Alpha8,
		// Token: 0x04000AF1 RID: 2801
		Alpha9,
		// Token: 0x04000AF2 RID: 2802
		Exclaim = 33,
		// Token: 0x04000AF3 RID: 2803
		DoubleQuote,
		// Token: 0x04000AF4 RID: 2804
		Hash,
		// Token: 0x04000AF5 RID: 2805
		Dollar,
		// Token: 0x04000AF6 RID: 2806
		Percent,
		// Token: 0x04000AF7 RID: 2807
		Ampersand,
		// Token: 0x04000AF8 RID: 2808
		Quote,
		// Token: 0x04000AF9 RID: 2809
		LeftParen,
		// Token: 0x04000AFA RID: 2810
		RightParen,
		// Token: 0x04000AFB RID: 2811
		Asterisk,
		// Token: 0x04000AFC RID: 2812
		Plus,
		// Token: 0x04000AFD RID: 2813
		Comma,
		// Token: 0x04000AFE RID: 2814
		Minus,
		// Token: 0x04000AFF RID: 2815
		Period,
		// Token: 0x04000B00 RID: 2816
		Slash,
		// Token: 0x04000B01 RID: 2817
		Colon = 58,
		// Token: 0x04000B02 RID: 2818
		Semicolon,
		// Token: 0x04000B03 RID: 2819
		Less,
		// Token: 0x04000B04 RID: 2820
		Equals,
		// Token: 0x04000B05 RID: 2821
		Greater,
		// Token: 0x04000B06 RID: 2822
		Question,
		// Token: 0x04000B07 RID: 2823
		At,
		// Token: 0x04000B08 RID: 2824
		LeftBracket = 91,
		// Token: 0x04000B09 RID: 2825
		Backslash,
		// Token: 0x04000B0A RID: 2826
		RightBracket,
		// Token: 0x04000B0B RID: 2827
		Caret,
		// Token: 0x04000B0C RID: 2828
		Underscore,
		// Token: 0x04000B0D RID: 2829
		BackQuote,
		// Token: 0x04000B0E RID: 2830
		A,
		// Token: 0x04000B0F RID: 2831
		B,
		// Token: 0x04000B10 RID: 2832
		C,
		// Token: 0x04000B11 RID: 2833
		D,
		// Token: 0x04000B12 RID: 2834
		E,
		// Token: 0x04000B13 RID: 2835
		F,
		// Token: 0x04000B14 RID: 2836
		G,
		// Token: 0x04000B15 RID: 2837
		H,
		// Token: 0x04000B16 RID: 2838
		I,
		// Token: 0x04000B17 RID: 2839
		J,
		// Token: 0x04000B18 RID: 2840
		K,
		// Token: 0x04000B19 RID: 2841
		L,
		// Token: 0x04000B1A RID: 2842
		M,
		// Token: 0x04000B1B RID: 2843
		N,
		// Token: 0x04000B1C RID: 2844
		O,
		// Token: 0x04000B1D RID: 2845
		P,
		// Token: 0x04000B1E RID: 2846
		Q,
		// Token: 0x04000B1F RID: 2847
		R,
		// Token: 0x04000B20 RID: 2848
		S,
		// Token: 0x04000B21 RID: 2849
		T,
		// Token: 0x04000B22 RID: 2850
		U,
		// Token: 0x04000B23 RID: 2851
		V,
		// Token: 0x04000B24 RID: 2852
		W,
		// Token: 0x04000B25 RID: 2853
		X,
		// Token: 0x04000B26 RID: 2854
		Y,
		// Token: 0x04000B27 RID: 2855
		Z,
		// Token: 0x04000B28 RID: 2856
		LeftCurlyBracket,
		// Token: 0x04000B29 RID: 2857
		Pipe,
		// Token: 0x04000B2A RID: 2858
		RightCurlyBracket,
		// Token: 0x04000B2B RID: 2859
		Tilde,
		// Token: 0x04000B2C RID: 2860
		Numlock = 300,
		// Token: 0x04000B2D RID: 2861
		CapsLock,
		// Token: 0x04000B2E RID: 2862
		ScrollLock,
		// Token: 0x04000B2F RID: 2863
		RightShift,
		// Token: 0x04000B30 RID: 2864
		LeftShift,
		// Token: 0x04000B31 RID: 2865
		RightControl,
		// Token: 0x04000B32 RID: 2866
		LeftControl,
		// Token: 0x04000B33 RID: 2867
		RightAlt,
		// Token: 0x04000B34 RID: 2868
		LeftAlt,
		// Token: 0x04000B35 RID: 2869
		LeftCommand = 310,
		// Token: 0x04000B36 RID: 2870
		LeftApple = 310,
		// Token: 0x04000B37 RID: 2871
		LeftWindows,
		// Token: 0x04000B38 RID: 2872
		RightCommand = 309,
		// Token: 0x04000B39 RID: 2873
		RightApple = 309,
		// Token: 0x04000B3A RID: 2874
		RightWindows = 312,
		// Token: 0x04000B3B RID: 2875
		AltGr,
		// Token: 0x04000B3C RID: 2876
		Help = 315,
		// Token: 0x04000B3D RID: 2877
		Print,
		// Token: 0x04000B3E RID: 2878
		SysReq,
		// Token: 0x04000B3F RID: 2879
		Break,
		// Token: 0x04000B40 RID: 2880
		Menu,
		// Token: 0x04000B41 RID: 2881
		Mouse0 = 323,
		// Token: 0x04000B42 RID: 2882
		Mouse1,
		// Token: 0x04000B43 RID: 2883
		Mouse2,
		// Token: 0x04000B44 RID: 2884
		Mouse3,
		// Token: 0x04000B45 RID: 2885
		Mouse4,
		// Token: 0x04000B46 RID: 2886
		Mouse5,
		// Token: 0x04000B47 RID: 2887
		Mouse6,
		// Token: 0x04000B48 RID: 2888
		JoystickButton0,
		// Token: 0x04000B49 RID: 2889
		JoystickButton1,
		// Token: 0x04000B4A RID: 2890
		JoystickButton2,
		// Token: 0x04000B4B RID: 2891
		JoystickButton3,
		// Token: 0x04000B4C RID: 2892
		JoystickButton4,
		// Token: 0x04000B4D RID: 2893
		JoystickButton5,
		// Token: 0x04000B4E RID: 2894
		JoystickButton6,
		// Token: 0x04000B4F RID: 2895
		JoystickButton7,
		// Token: 0x04000B50 RID: 2896
		JoystickButton8,
		// Token: 0x04000B51 RID: 2897
		JoystickButton9,
		// Token: 0x04000B52 RID: 2898
		JoystickButton10,
		// Token: 0x04000B53 RID: 2899
		JoystickButton11,
		// Token: 0x04000B54 RID: 2900
		JoystickButton12,
		// Token: 0x04000B55 RID: 2901
		JoystickButton13,
		// Token: 0x04000B56 RID: 2902
		JoystickButton14,
		// Token: 0x04000B57 RID: 2903
		JoystickButton15,
		// Token: 0x04000B58 RID: 2904
		JoystickButton16,
		// Token: 0x04000B59 RID: 2905
		JoystickButton17,
		// Token: 0x04000B5A RID: 2906
		JoystickButton18,
		// Token: 0x04000B5B RID: 2907
		JoystickButton19,
		// Token: 0x04000B5C RID: 2908
		Joystick1Button0,
		// Token: 0x04000B5D RID: 2909
		Joystick1Button1,
		// Token: 0x04000B5E RID: 2910
		Joystick1Button2,
		// Token: 0x04000B5F RID: 2911
		Joystick1Button3,
		// Token: 0x04000B60 RID: 2912
		Joystick1Button4,
		// Token: 0x04000B61 RID: 2913
		Joystick1Button5,
		// Token: 0x04000B62 RID: 2914
		Joystick1Button6,
		// Token: 0x04000B63 RID: 2915
		Joystick1Button7,
		// Token: 0x04000B64 RID: 2916
		Joystick1Button8,
		// Token: 0x04000B65 RID: 2917
		Joystick1Button9,
		// Token: 0x04000B66 RID: 2918
		Joystick1Button10,
		// Token: 0x04000B67 RID: 2919
		Joystick1Button11,
		// Token: 0x04000B68 RID: 2920
		Joystick1Button12,
		// Token: 0x04000B69 RID: 2921
		Joystick1Button13,
		// Token: 0x04000B6A RID: 2922
		Joystick1Button14,
		// Token: 0x04000B6B RID: 2923
		Joystick1Button15,
		// Token: 0x04000B6C RID: 2924
		Joystick1Button16,
		// Token: 0x04000B6D RID: 2925
		Joystick1Button17,
		// Token: 0x04000B6E RID: 2926
		Joystick1Button18,
		// Token: 0x04000B6F RID: 2927
		Joystick1Button19,
		// Token: 0x04000B70 RID: 2928
		Joystick2Button0,
		// Token: 0x04000B71 RID: 2929
		Joystick2Button1,
		// Token: 0x04000B72 RID: 2930
		Joystick2Button2,
		// Token: 0x04000B73 RID: 2931
		Joystick2Button3,
		// Token: 0x04000B74 RID: 2932
		Joystick2Button4,
		// Token: 0x04000B75 RID: 2933
		Joystick2Button5,
		// Token: 0x04000B76 RID: 2934
		Joystick2Button6,
		// Token: 0x04000B77 RID: 2935
		Joystick2Button7,
		// Token: 0x04000B78 RID: 2936
		Joystick2Button8,
		// Token: 0x04000B79 RID: 2937
		Joystick2Button9,
		// Token: 0x04000B7A RID: 2938
		Joystick2Button10,
		// Token: 0x04000B7B RID: 2939
		Joystick2Button11,
		// Token: 0x04000B7C RID: 2940
		Joystick2Button12,
		// Token: 0x04000B7D RID: 2941
		Joystick2Button13,
		// Token: 0x04000B7E RID: 2942
		Joystick2Button14,
		// Token: 0x04000B7F RID: 2943
		Joystick2Button15,
		// Token: 0x04000B80 RID: 2944
		Joystick2Button16,
		// Token: 0x04000B81 RID: 2945
		Joystick2Button17,
		// Token: 0x04000B82 RID: 2946
		Joystick2Button18,
		// Token: 0x04000B83 RID: 2947
		Joystick2Button19,
		// Token: 0x04000B84 RID: 2948
		Joystick3Button0,
		// Token: 0x04000B85 RID: 2949
		Joystick3Button1,
		// Token: 0x04000B86 RID: 2950
		Joystick3Button2,
		// Token: 0x04000B87 RID: 2951
		Joystick3Button3,
		// Token: 0x04000B88 RID: 2952
		Joystick3Button4,
		// Token: 0x04000B89 RID: 2953
		Joystick3Button5,
		// Token: 0x04000B8A RID: 2954
		Joystick3Button6,
		// Token: 0x04000B8B RID: 2955
		Joystick3Button7,
		// Token: 0x04000B8C RID: 2956
		Joystick3Button8,
		// Token: 0x04000B8D RID: 2957
		Joystick3Button9,
		// Token: 0x04000B8E RID: 2958
		Joystick3Button10,
		// Token: 0x04000B8F RID: 2959
		Joystick3Button11,
		// Token: 0x04000B90 RID: 2960
		Joystick3Button12,
		// Token: 0x04000B91 RID: 2961
		Joystick3Button13,
		// Token: 0x04000B92 RID: 2962
		Joystick3Button14,
		// Token: 0x04000B93 RID: 2963
		Joystick3Button15,
		// Token: 0x04000B94 RID: 2964
		Joystick3Button16,
		// Token: 0x04000B95 RID: 2965
		Joystick3Button17,
		// Token: 0x04000B96 RID: 2966
		Joystick3Button18,
		// Token: 0x04000B97 RID: 2967
		Joystick3Button19,
		// Token: 0x04000B98 RID: 2968
		Joystick4Button0,
		// Token: 0x04000B99 RID: 2969
		Joystick4Button1,
		// Token: 0x04000B9A RID: 2970
		Joystick4Button2,
		// Token: 0x04000B9B RID: 2971
		Joystick4Button3,
		// Token: 0x04000B9C RID: 2972
		Joystick4Button4,
		// Token: 0x04000B9D RID: 2973
		Joystick4Button5,
		// Token: 0x04000B9E RID: 2974
		Joystick4Button6,
		// Token: 0x04000B9F RID: 2975
		Joystick4Button7,
		// Token: 0x04000BA0 RID: 2976
		Joystick4Button8,
		// Token: 0x04000BA1 RID: 2977
		Joystick4Button9,
		// Token: 0x04000BA2 RID: 2978
		Joystick4Button10,
		// Token: 0x04000BA3 RID: 2979
		Joystick4Button11,
		// Token: 0x04000BA4 RID: 2980
		Joystick4Button12,
		// Token: 0x04000BA5 RID: 2981
		Joystick4Button13,
		// Token: 0x04000BA6 RID: 2982
		Joystick4Button14,
		// Token: 0x04000BA7 RID: 2983
		Joystick4Button15,
		// Token: 0x04000BA8 RID: 2984
		Joystick4Button16,
		// Token: 0x04000BA9 RID: 2985
		Joystick4Button17,
		// Token: 0x04000BAA RID: 2986
		Joystick4Button18,
		// Token: 0x04000BAB RID: 2987
		Joystick4Button19,
		// Token: 0x04000BAC RID: 2988
		Joystick5Button0,
		// Token: 0x04000BAD RID: 2989
		Joystick5Button1,
		// Token: 0x04000BAE RID: 2990
		Joystick5Button2,
		// Token: 0x04000BAF RID: 2991
		Joystick5Button3,
		// Token: 0x04000BB0 RID: 2992
		Joystick5Button4,
		// Token: 0x04000BB1 RID: 2993
		Joystick5Button5,
		// Token: 0x04000BB2 RID: 2994
		Joystick5Button6,
		// Token: 0x04000BB3 RID: 2995
		Joystick5Button7,
		// Token: 0x04000BB4 RID: 2996
		Joystick5Button8,
		// Token: 0x04000BB5 RID: 2997
		Joystick5Button9,
		// Token: 0x04000BB6 RID: 2998
		Joystick5Button10,
		// Token: 0x04000BB7 RID: 2999
		Joystick5Button11,
		// Token: 0x04000BB8 RID: 3000
		Joystick5Button12,
		// Token: 0x04000BB9 RID: 3001
		Joystick5Button13,
		// Token: 0x04000BBA RID: 3002
		Joystick5Button14,
		// Token: 0x04000BBB RID: 3003
		Joystick5Button15,
		// Token: 0x04000BBC RID: 3004
		Joystick5Button16,
		// Token: 0x04000BBD RID: 3005
		Joystick5Button17,
		// Token: 0x04000BBE RID: 3006
		Joystick5Button18,
		// Token: 0x04000BBF RID: 3007
		Joystick5Button19,
		// Token: 0x04000BC0 RID: 3008
		Joystick6Button0,
		// Token: 0x04000BC1 RID: 3009
		Joystick6Button1,
		// Token: 0x04000BC2 RID: 3010
		Joystick6Button2,
		// Token: 0x04000BC3 RID: 3011
		Joystick6Button3,
		// Token: 0x04000BC4 RID: 3012
		Joystick6Button4,
		// Token: 0x04000BC5 RID: 3013
		Joystick6Button5,
		// Token: 0x04000BC6 RID: 3014
		Joystick6Button6,
		// Token: 0x04000BC7 RID: 3015
		Joystick6Button7,
		// Token: 0x04000BC8 RID: 3016
		Joystick6Button8,
		// Token: 0x04000BC9 RID: 3017
		Joystick6Button9,
		// Token: 0x04000BCA RID: 3018
		Joystick6Button10,
		// Token: 0x04000BCB RID: 3019
		Joystick6Button11,
		// Token: 0x04000BCC RID: 3020
		Joystick6Button12,
		// Token: 0x04000BCD RID: 3021
		Joystick6Button13,
		// Token: 0x04000BCE RID: 3022
		Joystick6Button14,
		// Token: 0x04000BCF RID: 3023
		Joystick6Button15,
		// Token: 0x04000BD0 RID: 3024
		Joystick6Button16,
		// Token: 0x04000BD1 RID: 3025
		Joystick6Button17,
		// Token: 0x04000BD2 RID: 3026
		Joystick6Button18,
		// Token: 0x04000BD3 RID: 3027
		Joystick6Button19,
		// Token: 0x04000BD4 RID: 3028
		Joystick7Button0,
		// Token: 0x04000BD5 RID: 3029
		Joystick7Button1,
		// Token: 0x04000BD6 RID: 3030
		Joystick7Button2,
		// Token: 0x04000BD7 RID: 3031
		Joystick7Button3,
		// Token: 0x04000BD8 RID: 3032
		Joystick7Button4,
		// Token: 0x04000BD9 RID: 3033
		Joystick7Button5,
		// Token: 0x04000BDA RID: 3034
		Joystick7Button6,
		// Token: 0x04000BDB RID: 3035
		Joystick7Button7,
		// Token: 0x04000BDC RID: 3036
		Joystick7Button8,
		// Token: 0x04000BDD RID: 3037
		Joystick7Button9,
		// Token: 0x04000BDE RID: 3038
		Joystick7Button10,
		// Token: 0x04000BDF RID: 3039
		Joystick7Button11,
		// Token: 0x04000BE0 RID: 3040
		Joystick7Button12,
		// Token: 0x04000BE1 RID: 3041
		Joystick7Button13,
		// Token: 0x04000BE2 RID: 3042
		Joystick7Button14,
		// Token: 0x04000BE3 RID: 3043
		Joystick7Button15,
		// Token: 0x04000BE4 RID: 3044
		Joystick7Button16,
		// Token: 0x04000BE5 RID: 3045
		Joystick7Button17,
		// Token: 0x04000BE6 RID: 3046
		Joystick7Button18,
		// Token: 0x04000BE7 RID: 3047
		Joystick7Button19,
		// Token: 0x04000BE8 RID: 3048
		Joystick8Button0,
		// Token: 0x04000BE9 RID: 3049
		Joystick8Button1,
		// Token: 0x04000BEA RID: 3050
		Joystick8Button2,
		// Token: 0x04000BEB RID: 3051
		Joystick8Button3,
		// Token: 0x04000BEC RID: 3052
		Joystick8Button4,
		// Token: 0x04000BED RID: 3053
		Joystick8Button5,
		// Token: 0x04000BEE RID: 3054
		Joystick8Button6,
		// Token: 0x04000BEF RID: 3055
		Joystick8Button7,
		// Token: 0x04000BF0 RID: 3056
		Joystick8Button8,
		// Token: 0x04000BF1 RID: 3057
		Joystick8Button9,
		// Token: 0x04000BF2 RID: 3058
		Joystick8Button10,
		// Token: 0x04000BF3 RID: 3059
		Joystick8Button11,
		// Token: 0x04000BF4 RID: 3060
		Joystick8Button12,
		// Token: 0x04000BF5 RID: 3061
		Joystick8Button13,
		// Token: 0x04000BF6 RID: 3062
		Joystick8Button14,
		// Token: 0x04000BF7 RID: 3063
		Joystick8Button15,
		// Token: 0x04000BF8 RID: 3064
		Joystick8Button16,
		// Token: 0x04000BF9 RID: 3065
		Joystick8Button17,
		// Token: 0x04000BFA RID: 3066
		Joystick8Button18,
		// Token: 0x04000BFB RID: 3067
		Joystick8Button19
	}
}
