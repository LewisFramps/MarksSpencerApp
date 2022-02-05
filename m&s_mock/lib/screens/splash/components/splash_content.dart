import 'package:flutter/material.dart';

import '../../../constants.dart';
import '../../../size_config.dart';

class SplashContent extends StatelessWidget {
  const SplashContent({
    Key? key,
    this.text,
    this.image,
  }) : super(key: key);
  final String? text, image;

  @override
  Widget build(BuildContext context) {
    return Column(
      children: <Widget>[
        Spacer(),
        Text(
          "M&S",
          style: TextStyle(
            fontSize: getProportionateScreenWidth(66),
            color: Colors.lightGreen,
            fontWeight: FontWeight.bold,
          ),
        ),
        Text(
          text!,
          textAlign: TextAlign.center,
          style: TextStyle(
            fontSize: getProportionateScreenWidth(16),
            color: Colors.grey,
            fontWeight: FontWeight.bold,
          ),
        ),
        Spacer(flex: 5),
        Image.asset(
          image!,
          height:434,
          width:320,
        ),
      ],
    );
  }
}
